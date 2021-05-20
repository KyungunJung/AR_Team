using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBtn : MonoBehaviour
{
    public GameObject Sound;
    // Start is called before the first frame update
public void OnClickSound()
    {
        Sound.SetActive(true);
    }
}
