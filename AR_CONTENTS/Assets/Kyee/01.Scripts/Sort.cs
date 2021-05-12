using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Puzzle : MonoBehaviour
{
    //ī�� �迭
    public GameObject[] cards;

    //ī�� ��
    public int[] cardValues;

    //������ ī�� ��
    int selectCardValue;

    //���� ���� �޴� ī�� ����Ʈ
    public List<int> sameCardList;

    //ī�� ������
    int Size = 100;

    private void Start()
    {
        //ī�� �� ���� �Ҵ�
        cardValues = new int[cards.Length];

        sameCardList = new List<int>();
    }
    void InitCard()
    {
        //���� ī�� ����Ʈ ����
        sameCardList.Clear();

        //ī�尪 ����
        for (int i = 0; i < cardValues.Length; i++)
        {
            cardValues[i] = Random.Range(0, 2);

            //ī�� �� ����
            //0�̸� ��
            //if (cardValues[i] == 0)
            //{
            //    cards[i].color = new Color(1, 1, 1, 1);
            //}
            ////1�̸� ��
            //else
            //{
            //    cards[i].color = new Color(1, 0, 0, 0.5f);
            //}
        }
    }

    private void Update()
    {
        //1��Ű�� ������ ī�帮��
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            InitCard();
        }


        if (Input.GetMouseButtonDown(0))
        {
            Transform rt = cards[0].GetComponent<Transform>();

            int X = (int)(Input.mousePosition.x - rt.transform.position.x);
            int Y = (int)(Input.mousePosition.y - rt.transform.position.y);

            int Index = (X / Size) + (Y / Size) * 4;
            print(Index);

            //������ ���� ���� ����Ʈ�� �߰�
            sameCardList.Add(Index);

            //������ ī�� �� ����
            selectCardValue = cardValues[Index];

            FindNearCard(Index);

            ////���� ī�帮��Ʈ �� ����
            //for (int i = 0; i < sameCardList.Count; i++)
            //{
            //    cards[sameCardList[i]].color = Color.green;
            //}
        }

    }
    void FindNearCard(int Index)
    {
        if (Index / 4 > 0)
        {
            int XD = Index - 4;
            print(XD);
            FindSameCard(XD);
        }
        if (Index / 4 < 2)            // == XY / ���ΰ��� < ���ΰ��� - 1 
        {
            int XU = Index + 4;
            print(XU);
            FindSameCard(XU);
        }

        if (Index % 4 > 0)
        {
            int XL = Index - 1;
            print(XL);
            FindSameCard(XL);
        }
        if (Index % 4 < 3)           // XY % ���ΰ��� < ���ΰ��� - 1 
        {
            int XR = Index + 1;
            print(XR);
            FindSameCard(XR);


        }

    }

    void FindSameCard(int Index)
    {
        //ã�� ���� cardValues����Ʈ�� �����Ѵٸ� �Լ��� ������
        for (int i = 0; i < sameCardList.Count; i++)
        {
            if (sameCardList[i] == Index)
            {
                return;
            }
        }

        //���࿡ index�� �ش�Ǵ� ī�尪�� ���� ������ ī���� ���� ���ٸ�
        if (cardValues[Index] == selectCardValue)
        {
            //���� ī�� ����Ʈ�� �߰�
            sameCardList.Add(Index);

            //�߰��� �𿡼� �ٽ� �˻�
            FindNearCard(Index);
        }

    }
}