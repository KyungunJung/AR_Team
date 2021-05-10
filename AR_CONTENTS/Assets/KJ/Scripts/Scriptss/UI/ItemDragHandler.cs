using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ItemDragHandler : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public enum Furniture_Type
    {
        Chair,
        Sofa,
        Table,
        Cabinet,
        Light
    }

    public GameObject furniture;

    public Furniture_Type type;
    ObjMove objMove;
    public Inventory Item { get; set; }

    private void Start()
    {
        objMove = GameObject.Find("Grid").GetComponent<ObjMove>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        objMove.trTarget = furniture.transform;
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero;

  
    }

    

  
}

