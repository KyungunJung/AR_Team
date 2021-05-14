using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ItemDragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
{
   public int index;
    public enum Furniture_Type
    {
        Sofa,
        Chair,
        Table,
        Cabinet,
        Light
    }

    public GameObject [] furniture;

    public Furniture_Type type;
    ObjMove objMove;
    public Inventory Item { get; set; }

    private void Start()
    {
        objMove = GameObject.Find("Grid").GetComponent<ObjMove>();
     
    }
    

    public void OnClickSofa()
    {
        index = (int)Furniture_Type.Sofa;
        if(furniture[index].GetComponent<Select>().enabled == true)
        {
            objMove.trTarget = furniture[index].transform;
        }
        else
        {
            objMove.trTarget = null;
        }
    }
    public void OnClickChair()
    {
        index = (int)Furniture_Type.Chair;

     if(furniture[index].GetComponent<Select>().enabled == true)
        {
        objMove.trTarget = furniture[index].transform;
        }
     else
        {
            objMove.trTarget = null;
        }
    }
    public void OnClickTable()
    {
        index = (int)Furniture_Type.Table;
        if (furniture[index].GetComponent<Select>().enabled == true)
        {
            objMove.trTarget = furniture[index].transform;
        }
        else
        {
            objMove.trTarget = null;
        }
    }
    public void OnClickCabinet()
    {
        index = (int)Furniture_Type.Cabinet;
            if(furniture[index].GetComponent<Select>().enabled == true)
            {
        objMove.trTarget = furniture[index].transform;

            }
            else
            {
                objMove.trTarget = null;
            }
    }
    public void OnClickLight()
    {
        index = (int)Furniture_Type.Light;
        if(furniture[index].GetComponent<Select>().enabled == true)
        {
        objMove.trTarget = furniture[index].transform;
        }
        else
        {
            objMove.trTarget = null;
        }
    }



    public void OnDrag(PointerEventData eventData)
    {
        print("�̵�" + index);
        
        //furniture�� ������ �ִ� �� �� [0~4]���̿� �ִ� ���� ��� ������Ʈ�� ��ġ ���� ���� �׸��� ������ �̵�.
       // objMove.trTarget = furniture[index].transform;
        
        //�巡�� �Ҷ� �̹����� ���콺 ������ ���󰡴°�
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //�巡�� �ߴ��� ���� �ڸ��� ���ư��°�
        transform.localPosition = Vector3.zero;
    }

}

