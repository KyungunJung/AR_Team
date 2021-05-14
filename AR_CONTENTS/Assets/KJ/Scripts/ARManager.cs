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
        //1.ī�޶� ��ġ, ���� �������� Ray ���� 
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);

#if UNITY_EDITOR
        RaycastHit hit;

       // int layer = 1 << LayerMask.NameToLayer("Ground");

        if (Physics.Raycast(ray, out hit, 100))
        {

            DetectedGround(hit.point);
        }
#else
        //2.�ٴڰ� �ε�����
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        if (rayManager.Raycast(ray, hits, TrackableType.Planes))
        {
            DetectedGround(hits[0].pose.position);
        }

#endif
        else
        {
            //4. �װ� �ƴϸ� Indicator�� ��Ȱ��ȭ 
            //Indicator.SetActive(false);

        }
        //���࿡ ȭ�� ��ġ�� �ߴٸ�
        if (Input.GetMouseButtonDown(0))
        {
            //���࿡ Indicator�� Ȱ��ȭ �Ǿ� �ִٸ� 
            if (Indicator.activeSelf)
            {
                //�ڵ��� Ȱ��ȭ
                Grid.SetActive(true);
                //�ڵ��� ��ġ�� Indicator ��ġ�� ����
                //�ڵ����� ȸ������ Indicator ȸ�������� ����
                print(Grid.name + "   " + Indicator.name);
                print(Grid.transform.position + "   " + Indicator.transform.position);
                Grid.transform.SetPositionAndRotation(Indicator.transform.position, Indicator.transform.rotation);
                print(Grid.transform.position + "   " + Indicator.transform.position);

                //UI Ȱ��ȭ

                //Indicator ��Ȱ��ȭ
                Indicator.SetActive(false);
                //ARManager ��Ȱ��ȭ
                enabled = false;
            }
        }
        
    }

    void DetectedGround(Vector3 hitPos)
    {
        //3.Indicator�� Ȱ��ȭ�ϰ� �ε��� ��ġ�� ���´�.
        Indicator.SetActive(true);
        Indicator.transform.position = hitPos;

        //4.ī�޶� �������� ȸ��
        Indicator.transform.eulerAngles = new Vector3(0, Camera.main.transform.eulerAngles.y, 0);
    }
}
