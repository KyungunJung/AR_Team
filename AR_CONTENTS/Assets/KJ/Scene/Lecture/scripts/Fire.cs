using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Fire : MonoBehaviour
{
    public GameObject cubefactory;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //UI �̺�Ʈ ����� �ٸ� Ŭ�� �̺�Ʈ Ȱ��ȭ���� �ʰ��ϱ�

        //PC.ver
        //���콺 �����Ͱ� UI�� �ö������� �Ʒ��� �������
        if (EventSystem.current.IsPointerOverGameObject() == false)
        {
            //��ư ������ �� ��������
            if (Input.GetMouseButtonDown(0))
            {
                GameObject go = Instantiate(cubefactory);
                go.transform.position = Camera.main.transform.position + Camera.main.transform.forward;

            }
        }

        //mobile.ver
        if (Input.GetMouseButtonDown(0))
        {
            if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId) == false)
            {

            }
        }
    }
}
