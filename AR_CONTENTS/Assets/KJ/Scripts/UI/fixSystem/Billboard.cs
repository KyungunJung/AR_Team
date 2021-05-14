using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Billboard : MonoBehaviour
{
  
    void Update()
    {
        //나의 앞방향을 카메라가 바라보는 방향으로 세팅
        transform.forward = Camera.main.transform.forward;
    }
}
