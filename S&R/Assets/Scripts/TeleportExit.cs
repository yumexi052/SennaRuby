using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class isTeleport : MonoBehaviour
{
    public string sceneToLoad;
    public string exitName;
    private void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetString("LastExitName", exitName);
        SceneManager.LoadScene(sceneToLoad);
    }
}
