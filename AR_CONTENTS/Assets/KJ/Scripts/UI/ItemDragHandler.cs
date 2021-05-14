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
        objMove.trTarget = furniture[index].transform;
    }
    public void OnClickChair()
    {
        index = (int)Furniture_Type.Chair;
        objMove.trTarget = furniture[index].transform;
    }
    public void OnClickTable()
    {
        index = (int)Furniture_Type.Table;
        objMove.trTarget = furniture[index].transform;
    }
    public void OnClickCabinet()
    {
        index = (int)Furniture_Type.Cabinet;
        objMove.trTarget = furniture[index].transform;
    }
    public void OnClickLight()
    {
        index = (int)Furniture_Type.Light;
        objMove.trTarget = furniture[index].transform;
    }



    public void OnDrag(PointerEventData eventData)
    {
        print("이동" + index);
        
        //furniture가 가지고 있는 것 중 [0~4]사이에 있는 것을 골라서 오브젝트의 위치 값을 따라서 그리드 단위로 이동.
        //objMove.trTarget = furniture[index].transform;
        
        //드래그 할때 이미지가 마우스 포지션 따라가는것
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //드래그 했던거 원래 자리로 돌아가는거
        transform.localPosition = Vector3.zero;
    }

}

