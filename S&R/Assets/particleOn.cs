using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleOn : MonoBehaviour
{
    private float timer = 0.0f;
    private bool isParticleOn = false;
    GameObject tips;
    GameObject traps;

    // Update is called once per frame
    void Update()
    {
        tips = GameObject.Find("TipsParticle");
        traps = GameObject.Find("TrapParticle");

        if (Input.GetKey(KeyCode.J) && !isParticleOn)
        {
            isParticleOn = true;
        }

        if (isParticleOn)
        {
            timer += Time.deltaTime;
            tips.GetComponent<ParticleSystem>().Play();
            traps.GetComponent<ParticleSystem>().Play();
        }

        if (timer > 1)
        {
            isParticleOn = false;
            tips.GetComponent<ParticleSystem>().Stop();
            traps.GetComponent<ParticleSystem>().Stop();
            timer = 0.0f;
        }
    }
}
