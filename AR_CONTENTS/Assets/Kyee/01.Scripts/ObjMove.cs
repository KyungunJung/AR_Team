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
        // 레이가 맞추고 있는 오브젝트의 정보를 담아오기 (수정사항)
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
        //    // 모델의 정보는 한 개만 담는다.
        //}





        // 왼쪽 마우스 버튼을 한번 더 클릭하면 오브젝트 회전 (수정사항)
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
