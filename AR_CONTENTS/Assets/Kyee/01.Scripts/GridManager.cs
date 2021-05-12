using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    // Start is called before the first frame update

    // 특정 그리드에 오브젝트 정보를 미리 할당
    // 오브젝트가 특정 위치에 있으면 인식됌 (print)

    // 마우스 클릭으로 해당 오브젝트가 위치를 결정했다는 것을 인식
    // 점수는 한번만 올려주기

    public int tileSize = 5;
    public int hCount = 5;
    public GameObject cube;
    public GameObject cube2;
    //public GameObject gridTile;
    //public GameObject gridTile2;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetMouseButton(0))
        {
            //int x = (int)Input.mousePosition.x;
            //int y = (int)Input.mousePosition.y;

            //int index = (x / tileSize) + (y / tileSize) * hCount;
            //print("현재 클릭한 곳 : " + index);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hits;
            
            if(Physics.Raycast(ray, out hits ))
            {
                
                
                //if(cube.transform.position == gridTile.transform.position)
                //{

                //    print("맞음");
                    
                //}

                //if(cube2.transform.position == gridTile2.transform.position)
                //{

                //    print("두번째도 맞음");
                //}
                    

                    //Scormanager UI 에 점수를 올린다.

                
                
                

                // 각 그리드에 해당 오브젝트 정보가 담겨있다
                // 마우스 클릭한 곳의 오브젝트 정보를 가져와라
                // 만약 오브젝트가 마우스 클릭한 곳의 정보와 같다면 프린트 ("같음")

            }

           

        }
        //if(Input.GetMouseButtonUp(0))
        //{

        //    if (cube.transform.position == gridTile.transform.position)
        //    {

        //        print("아님");

        //    }

        //}

        

    }
    
}
