using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ObjMove : MonoBehaviour
{
    public Transform trTarget;
    public Transform[] models;
    private void Update()
    {

        //���̰� ���߰� �ִ� ������Ʈ�� ������ ��ƿ���(��������)

        if (Input.GetMouseButton(0))
        
           if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId) == false)
          //if (EventSystem.current.IsPointerOverGameObject() == false)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                int layer = 1 << LayerMask.NameToLayer("Grid");
                if (Physics.Raycast(ray, out hit, 100, layer))
                {
                    if (trTarget != null)
                    {
                        trTarget.position = hit.transform.position;

                        trTarget.gameObject.SetActive(true);
                        //for (int i=0; i < models.Length; i++)
                        //{
                        //    models[i].transform.position = hit.transform.position;
                        //    // ���� ������ �� ���� ��´�.
                        //}
                    }
                }
            }
        }

        //���� ���콺 ��ư�� �ѹ� �� Ŭ���ϸ� ������Ʈ ȸ�� (��������)
        //if (Input.GetMouseButtonDown(1))
        //{

        //    trTarget.transform.Rotate(new Vector3(0, 45, 0));

        //    for (int i = 0; i < models.Length; i++)
        //    {
        //        models[i].transform.Rotate(new Vector3(0, 45, 0));
        //    }
        //}
    }










