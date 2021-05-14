using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARManager : MonoBehaviour
{
 

    public GameObject testCam;
    public GameObject arSesstion;
    public GameObject arSesstionOrigin;


    public GameObject Indicator;
    public GameObject Grid;


    //AR Raycast Manager
    ARRaycastManager rayManager;

    private void Awake()
    {
//#if UNITY_EDITOR
//        arSesstion.SetActive(false);
//        arSesstionOrigin.SetActive(false);
//        testCam.SetActive(true);

//#else
        arSesstion.SetActive(true);
        arSesstionOrigin.SetActive(true);
        testCam.SetActive(true);
                

//#endif
    }
    void Start()
    {
        rayManager = GetComponent<ARRaycastManager>();
       // Grid.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //1.카메라 위치, 보는 방향으로 Ray 만들어서 
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

#if UNITY_EDITOR
        RaycastHit hit;

       // int layer = 1 << LayerMask.NameToLayer("Ground");

        if (Physics.Raycast(ray, out hit, 100))
        {

            DetectedGround(hit.point);
        }
#else
        //2.바닥과 부딪히면
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        if (rayManager.Raycast(ray, hits, TrackableType.Planes))
        {
            DetectedGround(hits[0].pose.position);
        }

#endif
        else
        {
            //4. 그게 아니면 Indicator를 비활성화 
            //Indicator.SetActive(false);

        }
        //만약에 화면 터치를 했다면
        if (Input.GetMouseButtonDown(0))
        {
            //만약에 Indicator가 활성화 되어 있다면 
            if (Indicator.activeSelf)
            {
                //자동차 활성화
                Grid.SetActive(true);
                //자동차 위치를 Indicator 위치로 세팅
                //자동차의 회전값을 Indicator 회전값으로 세팅
                print(Grid.name + "   " + Indicator.name);
                print(Grid.transform.position + "   " + Indicator.transform.position);
                Grid.transform.SetPositionAndRotation(Indicator.transform.position, Indicator.transform.rotation);
                print(Grid.transform.position + "   " + Indicator.transform.position);

                //UI 활성화

                //Indicator 비활성화
                Indicator.SetActive(false);
                //ARManager 비활성화
                enabled = false;
            }
        }
        
    }

    void DetectedGround(Vector3 hitPos)
    {
        //3.Indicator를 활성화하고 부딪힌 위치에 놓는다.
        Indicator.SetActive(true);
        Indicator.transform.position = hitPos;

        //4.카메라 방향으로 회전
        Indicator.transform.eulerAngles = new Vector3(0, Camera.main.transform.eulerAngles.y, 0);
    }
}
