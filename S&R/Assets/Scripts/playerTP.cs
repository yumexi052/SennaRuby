using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTP : MonoBehaviour
{
    public static playerTP instance;
    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
