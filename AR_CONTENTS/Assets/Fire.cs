using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Fire : MonoBehaviour
{
    public GameObject cubeFactory;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //마우스 포인터가 UI 위에 올라가 있느냐?

#if UNITY_EDITOR
            //PC
            if (EventSystem.current.IsPointerOverGameObject() == false)
#else
                //모바일
                if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId) 
            == false)
#endif
            {
                GameObject go = Instantiate(cubeFactory);
                go.transform.position =
                    Camera.main.transform.position + Camera.main.transform.forward;

            }
        }
    }
}
