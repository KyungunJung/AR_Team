using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class first : MonoBehaviour
{
   public GameObject Lock;
   public GameObject Unlock;
    public GameObject asdf;
    // Update is called once per frame
    private void Start()
    {
        
    }
    void Update()
    {
        //만약에 Lock / unlock이 활성화일때
        if (Lock.activeSelf || Unlock.activeSelf)
        {
            print("s");
            //만약에 마우스의 위치가 ui위일때
            if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId)
            == false)
            {
                //버튼 누르면
                print("wq");
                    //움직임 멈춰!
                    asdf.SetActive(false);
                print("tq");
            }
        } 
    }
}
