using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObjRotation : MonoBehaviour
{

    //자신의 각도값
    float rotX;
    float rotY;

    //회전 속도
    public float rotSpeed = 200f;


    //좌우회전 가능
    public bool useRotH = false;

    //상하회전 가능
    public bool useRotV = false;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        //마우스 좌우 상하 움직임

        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");

        // 오브젝트의 각도를 누적
        if (useRotV)
        {
            rotX += my * rotSpeed * Time.deltaTime;
        }
        if (useRotH)
        {
            rotY += mx * rotSpeed * Time.deltaTime;
        }
        //각도를 세팅
        transform.localEulerAngles = new Vector3(-rotX, rotY, 0);

    }
}
