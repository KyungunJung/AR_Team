using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GridManager : MonoBehaviour
{
    // Start is called before the first frame update

    // Ư�� �׸��忡 ������Ʈ ������ �̸� �Ҵ�
    // ������Ʈ�� Ư�� ��ġ�� ������ �νĉ� (print)

    // ���콺 Ŭ������ �ش� ������Ʈ�� ��ġ�� �����ߴٴ� ���� �ν�
    // ������ �ѹ��� �÷��ֱ�

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
            //print("���� Ŭ���� �� : " + index);

            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //RaycastHit hits;

            //if (Physics.Raycast(ray, out hits))
            //{
            //}

        //}
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Check();
        //    print("üũ��");
        //}
        //if (Input.GetMouseButtonUp(0))
        //{
        //    Check();
        //    print("üũ��");
        //}


            
        //}
        //if (Input.GetMouseButtonUp(1))
        //{

        //    if (GridComplete())
        //    {
        //        print("Ŭ����");
        //    }
        //}
        
    }

    public void Check()
    {
        if (GridComplete())
        {
            print("Ŭ����");
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

    
    


        