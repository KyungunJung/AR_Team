using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    // Start is called before the first frame update

    // Ư�� �׸��忡 ������Ʈ ������ �̸� �Ҵ�
    // ������Ʈ�� Ư�� ��ġ�� ������ �νĉ� (print)

    // ���콺 Ŭ������ �ش� ������Ʈ�� ��ġ�� �����ߴٴ� ���� �ν�
    // ������ �ѹ��� �÷��ֱ�

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
            //print("���� Ŭ���� �� : " + index);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hits;
            
            if(Physics.Raycast(ray, out hits ))
            {
                
                
                //if(cube.transform.position == gridTile.transform.position)
                //{

                //    print("����");
                    
                //}

                //if(cube2.transform.position == gridTile2.transform.position)
                //{

                //    print("�ι�°�� ����");
                //}
                    

                    //Scormanager UI �� ������ �ø���.

                
                
                

                // �� �׸��忡 �ش� ������Ʈ ������ ����ִ�
                // ���콺 Ŭ���� ���� ������Ʈ ������ �����Ͷ�
                // ���� ������Ʈ�� ���콺 Ŭ���� ���� ������ ���ٸ� ����Ʈ ("����")

            }

           

        }
        //if(Input.GetMouseButtonUp(0))
        //{

        //    if (cube.transform.position == gridTile.transform.position)
        //    {

        //        print("�ƴ�");

        //    }

        //}

        

    }
    
}
