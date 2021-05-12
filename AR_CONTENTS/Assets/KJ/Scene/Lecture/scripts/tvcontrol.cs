using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class tvcontrol : MonoBehaviour
{
    // video player ��������
    VideoPlayer vp;
    void Start()
    {
        vp = GetComponent<VideoPlayer>();
        
        //�ӵ�����(���)
        vp.playbackSpeed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        //1.play
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            vp.Play();
        }
        //2.strop
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            vp.Stop();
        }
        //3.pause
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            vp.Pause();   
        }
        //4.�����ΰ���
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            vp.time += 5;
        }
        //5.�ڷΰ���
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            vp.time -= 5;
        }
    }
}
