using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SelectCabinet : MonoBehaviour
{
    int _index;
    ItemDragHandler itemIndex;
    private GameObject target;
    ObjMove objMove;
    public GameObject gridTile2;
    public GameObject dustFactory;
    
    public enum Furniture_Type
    {
        Sofa,
        Chair,
        Table,
        Cabinet,
        Light
    }
    public GameObject[] furniture;
    public Furniture_Type type;

    private void Start()
    {
        itemIndex = GameObject.Find("Image").GetComponent<ItemDragHandler>();
        objMove = GameObject.Find("Grid").GetComponent<ObjMove>();

    }
    void Update()

    {

        if (Input.GetMouseButton(0))

        {

            target = GetClickedObject();
            print("D");
            if (target.Equals(gameObject))  //���õȰ� �����

            {

                objMove.trTarget = furniture[3].transform;
                if(objMove.trTarget.transform.position == gridTile2.transform.position)
                {
                    print("����");

                }
                    
            }

        }

        if (Input.GetMouseButtonUp(0))
        {

            if(objMove.trTarget.transform.position == gridTile2.transform.position)
            {

                GameObject dust = Instantiate(dustFactory);
                dust.transform.position = transform.position;
                print("����");
            }
        }

    }
    private GameObject GetClickedObject()

    {
        RaycastHit hit;

        GameObject target = null;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //���콺 ����Ʈ ��ó ��ǥ�� �����. 

        if (true == (Physics.Raycast(ray.origin, ray.direction, out hit)))   //���콺 ��ó�� ������Ʈ�� �ִ��� Ȯ��

        {

            _index = itemIndex.index;
            print("����");
            target = hit.transform.gameObject;


        }
        return target;
    }

}




