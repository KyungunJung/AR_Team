using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Billboard : MonoBehaviour
{
  
    void Update()
    {
        //���� �չ����� ī�޶� �ٶ󺸴� �������� ����
        transform.forward = Camera.main.transform.forward;
    }
}
