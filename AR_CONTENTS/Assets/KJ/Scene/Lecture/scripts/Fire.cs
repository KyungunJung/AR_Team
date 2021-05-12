using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Fire : MonoBehaviour
{
    public GameObject cubefactory;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //UI 이벤트 실행시 다른 클릭 이벤트 활성화되지 않게하기

        //PC.ver
        //마우스 포인터가 UI에 올라가있으면 아래것 실행안함
        if (EventSystem.current.IsPointerOverGameObject() == false)
        {
            //버튼 눌렀을 때 옵젝생성
            if (Input.GetMouseButtonDown(0))
            {
                GameObject go = Instantiate(cubefactory);
                go.transform.position = Camera.main.transform.position + Camera.main.transform.forward;

            }
        }

        //mobile.ver
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId) == false)
            {

            }
        }
    }
}
