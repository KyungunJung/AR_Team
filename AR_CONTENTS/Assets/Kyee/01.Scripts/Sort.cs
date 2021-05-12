using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Puzzle : MonoBehaviour
{
    //카드 배열
    public GameObject[] cards;

    //카드 값
    public int[] cardValues;

    //선택한 카드 값
    int selectCardValue;

    //같은 값을 받는 카드 리스트
    public List<int> sameCardList;

    //카드 사이즈
    int Size = 100;

    private void Start()
    {
        //카드 값 공간 할당
        cardValues = new int[cards.Length];

        sameCardList = new List<int>();
    }
    void InitCard()
    {
        //같은 카드 리스트 리셋
        sameCardList.Clear();

        //카드값 세팅
        for (int i = 0; i < cardValues.Length; i++)
        {
            cardValues[i] = Random.Range(0, 2);

            //카드 색 세팅
            //0이면 흰
            //if (cardValues[i] == 0)
            //{
            //    cards[i].color = new Color(1, 1, 1, 1);
            //}
            ////1이면 빨
            //else
            //{
            //    cards[i].color = new Color(1, 0, 0, 0.5f);
            //}
        }
    }

    private void Update()
    {
        //1번키를 누르면 카드리셋
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

            //선택한 놈을 같은 리스트에 추가
            sameCardList.Add(Index);

            //선택한 카드 값 저장
            selectCardValue = cardValues[Index];

            FindNearCard(Index);

            ////같은 카드리스트 색 변경
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
        if (Index / 4 < 2)            // == XY / 가로갯수 < 세로갯수 - 1 
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
        if (Index % 4 < 3)           // XY % 가로갯수 < 가로갯수 - 1 
        {
            int XR = Index + 1;
            print(XR);
            FindSameCard(XR);


        }

    }

    void FindSameCard(int Index)
    {
        //찾은 값이 cardValues리스트에 존재한다면 함수를 나가라
        for (int i = 0; i < sameCardList.Count; i++)
        {
            if (sameCardList[i] == Index)
            {
                return;
            }
        }

        //만약에 index에 해당되는 카드값이 내가 선택한 카드의 값과 같다면
        if (cardValues[Index] == selectCardValue)
        {
            //같은 카드 리스트에 추가
            sameCardList.Add(Index);

            //추가한 놈에서 다시 검사
            FindNearCard(Index);
        }

    }
}