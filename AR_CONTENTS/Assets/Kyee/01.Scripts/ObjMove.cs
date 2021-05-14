using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ObjMove : MonoBehaviour
{
    public Transform trTarget;
    //public Transform[] models;

    private void Update()
    {

        //     레이가 맞추고 있는 오브젝트의 정보를 담아오기(수정사항)
       

            if (Input.GetMouseButton(0))
            {

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                int layer = 1 << LayerMask.NameToLayer("Grid");
                if (Physics.Raycast(ray, out hit, 100, layer))
                {
                    trTarget.position = hit.transform.position;

                    //for (int i=0; i < models.Length; i++)
                    //{
                    //    models[i].transform.position = hit.transform.position;
                    //    // 모델의 정보는 한 개만 담는다.
                    //}
                    trTarget.gameObject.SetActive(true);
                }
            }

            // 왼쪽 마우스 버튼을 한번 더 클릭하면 오브젝트 회전 (수정사항)
            if (Input.GetMouseButtonDown(1))
            {

            trTarget.transform.Rotate(new Vector3(0, 45, 0));
            GridManager gm = GameObject.Find("Grid").GetComponent<GridManager>();
            gm.Check();


           

                //for (int i = 0; i < models.Length; i++)
                //{
                //    models[i].transform.Rotate(new Vector3(0, 45, 0));
                //}

            }
        }
    }


