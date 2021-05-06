using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObjRotation : MonoBehaviour
{

    //�ڽ��� ������
    float rotX;
    float rotY;

    //ȸ�� �ӵ�
    public float rotSpeed = 200f;


    //�¿�ȸ�� ����
    public bool useRotH = false;

    //����ȸ�� ����
    public bool useRotV = false;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        //���콺 �¿� ���� ������

        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");

        // ������Ʈ�� ������ ����
        if (useRotV)
        {
            rotX += my * rotSpeed * Time.deltaTime;
        }
        if (useRotH)
        {
            rotY += mx * rotSpeed * Time.deltaTime;
        }
        //������ ����
        transform.localEulerAngles = new Vector3(-rotX, rotY, 0);

    }
}
