using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    public static bool speedUp = false;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.gameObject == GameObject.Find("Fox"))
        {
            speedUp = true;
            Debug.Log("yes");
        }
        else
        {
            Debug.Log("no");
        }
    }
}
