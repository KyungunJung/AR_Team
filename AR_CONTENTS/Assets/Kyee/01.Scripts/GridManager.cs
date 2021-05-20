using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GridManager : MonoBehaviour
{
    // Start is called before the first frame update

    // 특정 그리드에 오브젝트 정보를 미리 할당
    // 오브젝트가 특정 위치에 있으면 인식됌 (print)

    // 마우스 클릭으로 해당 오브젝트가 위치를 결정했다는 것을 인식
    // 점수는 한번만 올려주기

    public int tileSize = 5;
    public int hCount = 5;
    
    
    public GameObject[] furnitures;
    public GameObject[] grids;


    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    //       if (Input.GetMouseButton(0))
      //  {
            //int x = (int)Input.mousePosition.x;
            //int y = (int)Input.mousePosition.y;

            //int index = (x / tileSize) + (y / tileSize) * hCount;
            //print("현재 클릭한 곳 : " + index);

            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //RaycastHit hits;

            //if (Physics.Raycast(ray, out hits))
            //{
            //}

        //}
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Check();
        //    print("체크중");
        //}
        //if (Input.GetMouseButtonUp(0))
        //{
        //    Check();
        //    print("체크중");
        //}


            
        //}
        //if (Input.GetMouseButtonUp(1))
        //{

        //    if (GridComplete())
        //    {
        //        print("클리어");
        //    }
        //}
        
    }

    public void Check()
    {
        if (GridComplete())
        {
            print("클리어");
            SceneManager.LoadScene("ClearScene");
        }
    }

    bool GridComplete()
    {
        if (Vector3.Distance(furnitures[0].transform.position , grids[0].transform.position)>2)
            return false;
        if (Vector3.Angle(furnitures[0].transform.forward ,grids[0].transform.forward) > 5)
            return false;

        if (Vector3.Distance(furnitures[1].transform.position, grids[1].transform.position) > 2)
            return false;
        if (Vector3.Angle(furnitures[1].transform.forward, grids[1].transform.forward) > 5)
            return false;

        if (Vector3.Distance(furnitures[2].transform.position, grids[2].transform.position) > 2)
            return false;
        if (Vector3.Angle(furnitures[2].transform.forward, grids[2].transform.forward) > 364)
            return false;

        if (Vector3.Distance(furnitures[3].transform.position, grids[3].transform.position) > 2)
            return false;
        if (Vector3.Angle(furnitures[3].transform.forward, grids[3].transform.forward) > 5)
            return false;

        if (Vector3.Distance(furnitures[4].transform.position, grids[4].transform.position) > 2)
            return false;
        if (Vector3.Angle(furnitures[4].transform.forward, grids[4].transform.forward) > 364)
            return false;

        else
            return true;
    }
 }

    
    


        