using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptGerak : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            transform.Translate(0, 0, 1);
            Debug.Log("W ditekan");
        }
        if (Input.GetKeyDown("s"))
        {
            transform.Translate(0, 0, -1);
            Debug.Log("S ditekan");
        }
        if (Input.GetKeyDown("d"))
        {
            transform.Translate(1, 0, 0);
            Debug.Log("D ditekan");
        }
        if (Input.GetKeyDown("a"))
        {
            transform.Translate(-1, 0, 0);
            Debug.Log("A ditekan");
        }
    }
}
