using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class first : MonoBehaviour
{
   public GameObject Lock;
   public GameObject Unlock;
    public GameObject asdf;
    // Update is called once per frame
    private void Start()
    {
        
    }
    void Update()
    {
        //���࿡ Lock / unlock�� Ȱ��ȭ�϶�
        if (Lock.activeSelf || Unlock.activeSelf)
        {
            print("s");
            //���࿡ ���콺�� ��ġ�� ui���϶�
            if (EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId)
            == false)
            {
                //��ư ������
                print("wq");
                    //������ ����!
                    asdf.SetActive(false);
                print("tq");
            }
        } 
    }
}
