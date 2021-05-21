using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class itween : MonoBehaviour
{
    //애니메이션이 적용 될 오브젝트
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        // iTween.MoveBy(gameObject, iTween.Hash("x", 5, "time", 1));   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCompleteAni()
    {
        print("itween Complete");

    }

    void OnUpdateAni()
    {
        print("itween onupdate");
    }

    void OnUpdateAniUI(float value)
    {
        RectTransform rt = target.GetComponent<RectTransform>();
        Vector2 pos = rt.anchoredPosition;
        pos.x = value;
        rt.anchoredPosition = pos;
        print(value);
    }

    public void OnClickGacha()
    {

        //iTween.MoveBy(target, iTween.Hash(

        //    "x", 5,
        //    "time", 0.5,
        //    "easetype", iTween.EaseType.easeOutBounce,
        //    "oncomplete", "OnCompleteAni",
        //    "oncompletarget", gameObject,
        //    "onupdate", "OnUpdateAni",
        //    "onupdatetarget", gameObject,
        //   "looptype", iTween.LoopType.pingPong
        //    ));


        RectTransform rt = target.GetComponent<RectTransform>();

        iTween.ValueTo(gameObject, iTween.Hash(
            "time", 1,
        "from", rt.anchoredPosition.x,
        "to", 0,
         "easetype", iTween.EaseType.easeOutBounce,
        "onupdate", "OnUpdateAniUI",
        "onupdatetarget", gameObject

        ));


        //iTween.ScaleTo(target, iTween.Hash(
        //    "scale", new Vector3(19, 8.5f, 11),
        //    "time", 1,
        //    "easetype", iTween.EaseType.easeOutBounce

        //    ));

    }
}
