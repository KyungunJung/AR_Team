using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Coupon : MonoBehaviour
{
    public Image DrawImage; // ���� �̹����� ����� ������Ʈ

    //���� �̹���
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

    // ����
    public int RandomInt; // ���� ����



    void Update()
    {
        RandomInt = Random.Range(0, 10); // ���� ������ �����մϴ�.
    }

    public void OneDraw() // 1ȸ �̱� ��ư�� Ŭ�� ��
    {
        
        if (RandomInt == 1) // RandomInt�� 1�̶��
        {
            DrawImage.sprite = Image1; // DrawImage�� Sprite�� Image1(Sprite)�� �����մϴ�.
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
        Invoke("CloseDraw", 0.1f); // 2�� �ڿ� CloseDraw �Լ��� �����մϴ�.
    }

    public void CloseDraw() // �̱� ��ũ��Ʈ�� ����ǰ� �ڵ����� ����ǰ� �մϴ�.
    {
        //DrawImage.sprite = null; // �����ߴ� �̹����� �ʱ�ȭ�մϴ�.
       // gameObject.SetActive(false);
    }
    //IEnumerator NextScene()
    //{
    //    yield return new WaitForSeconds(5);
    //    SceneManager.LoadScene("FirstScene");

    //}
}