using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class rockRoll : MonoBehaviour
{
    public int moveSpeed = 3;
    public static bool isHit = false;
    //public AudioClip hitSound;
    //public AudioClip resetSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Fox")
        {
            //AudioSource audio = GetComponent<AudioSource>();
            //audio.clip = hitSound;
            //audio.Play();
            isHit = true;
        }
    }

    void Update()
    {
        if (trap.speedUp)
            moveSpeed += 10;
    }
}
