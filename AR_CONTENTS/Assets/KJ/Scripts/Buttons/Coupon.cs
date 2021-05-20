using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Coupon : MonoBehaviour
{
    public Image DrawImage; // 랜덤 이미지를 출력할 오브젝트

    //숫자 이미지
    public Sprite image0;
    public Sprite Image1;
    public Sprite Image2;
    public Sprite Image3;
    public Sprite Image4;
    public Sprite Image5;
    public Sprite Image6;
    public Sprite Image7;
    public Sprite Image8;
    public Sprite Image9;
    public Sprite Image10;

    // 변수
    public int RandomInt; // 랜덤 변수



    void Update()
    {
        RandomInt = Random.Range(0, 10); // 랜덤 범위를 설정합니다.
    }

    public void OneDraw() // 1회 뽑기 버튼을 클릭 시
    {
        if(RandomInt == 0)
        {
            DrawImage.sprite = image0;
        }
        
        if (RandomInt == 1) // RandomInt가 1이라면
        {
            DrawImage.sprite = Image1; // DrawImage의 Sprite에 Image1(Sprite)를 적용합니다.
        }
        else if (RandomInt == 2)
        {
            DrawImage.sprite = Image2;
        }
        else if (RandomInt == 3)
        {
            DrawImage.sprite = Image3;
        }
        else if (RandomInt == 4)
        {
            DrawImage.sprite = Image4;
        }
        else if (RandomInt == 5)
        {
            DrawImage.sprite = Image5;
        }
        else if (RandomInt == 6)
        {
            DrawImage.sprite = Image6;
        }
        else if (RandomInt == 7)
        {
            DrawImage.sprite = Image7;
        }
        else if (RandomInt == 8)
        {
            DrawImage.sprite = Image8;
        }
        else if (RandomInt == 9)
        {
            DrawImage.sprite = Image9;
        }
        else if (RandomInt == 10)
        {
            DrawImage.sprite = Image10;
        }
        Invoke("CloseDraw", 0.1f); // 2초 뒤에 CloseDraw 함수를 실행합니다.
    }

    public void CloseDraw() // 뽑기 스크립트가 실행되고 자동으로 실행되게 합니다.
    {
        //DrawImage.sprite = null; // 적용했던 이미지를 초기화합니다.
        //       gameObject.SetActive(false);
        GetComponent<Button>().interactable = false;

    }
    //IEnumerator NextScene()
    //{
    //    yield return new WaitForSeconds(5);
    //    SceneManager.LoadScene("FirstScene");

    //}
}
