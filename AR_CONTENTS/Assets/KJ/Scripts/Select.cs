using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Select : MonoBehaviour
{
    int _index;
    ItemDragHandler itemIndex;
    private GameObject target;
    ObjMove objMove;
    float fixedRotation = 0;
    public Transform t;

    public GameObject gridTile;
    public GameObject dustFactory;


    public int furnitureIdx;


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
        //ī�޶� ���� �������� �����̱�
        t.transform.forward = Camera.main.transform.forward;

        //y�� ������Ű��
        t.eulerAngles = new Vector3(fixedRotation, t.eulerAngles.y, fixedRotation);




        if (Input.GetMouseButtonDown(0))
        {

            target = GetClickedObject();
            
            if (target != null && target.Equals(gameObject))  //���õȰ� �����
            {
                objMove.trTarget = furniture[furnitureIdx].transform;


            }

        }

        if (Input.GetMouseButtonUp(0))
        {

            if (objMove.trTarget.transform.position == gridTile.transform.position)
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
            target = hit.transform.gameObject;

        }
        return target;
    }

    public void SetRock()
    {
        enabled = false;

        if (objMove.trTarget != null)
        {
            objMove.trTarget = null;
        }
    }
}




