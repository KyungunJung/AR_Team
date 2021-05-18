using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustEft : MonoBehaviour
{
    float destroyTime = 1;
    float currTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        ParticleSystem ps = GetComponent<ParticleSystem>();
        ps.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;

        if (destroyTime < currTime)
        {

            Destroy(gameObject);
        }
    }
}
