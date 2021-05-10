using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjMove : MonoBehaviour
{
    public Transform trChair;
    public Transform trSofa;
    //public Transform[] models;
    public GameObject[] models;
    Transform move;
    ObjIndex index;


    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        // ���̰� ���߰� �ִ� ������Ʈ�� ������ ��ƿ��� (��������)
        if (Input.GetMouseButtonDown(0))
        {
            index = hit.transform.gameObject.GetComponent<ObjIndex>();
            print(models[index.index].transform.gameObject);
            models[index.index].transform.position = hit.transform.position;

        }
        else if(Input.GetMouseButton(0))
        {
            
            int layer = 1 << LayerMask.NameToLayer("Grid");

            if (Physics.Raycast(ray, out hit, 100, layer))
            {
                move = hit.transform.position;
                

                
                //    print(hit.transform.position);
                //trSofa.position = hit.transform.position;
            }
            // ObjIndex index = GetComponent<ObjIndex>();               
            // models[index].position = hit.transform.position;



        }






        //for (int i=0; i < models.Length; i++)
        //{
        //    models[i].transform.position = hit.transform.position;
        //    // ���� ������ �� ���� ��´�.
        //}





        // ���� ���콺 ��ư�� �ѹ� �� Ŭ���ϸ� ������Ʈ ȸ�� (��������)
        if (Input.GetMouseButtonDown(1))
        {
            trChair.transform.Rotate(new Vector3(0, 45, 0));


            //for (int i = 0; i < models.Length; i++)
            //{
            //    models[i].transform.Rotate(new Vector3(0, 45, 0));
            //}

        }

    }


}
