using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptDua : MonoBehaviour
{
    Text numText;
    int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        numText = GameObject.Find("numText").GetComponent<Text>();
        numText.text = num.ToString();
    }

    // Update is called once per frame
    public void AdditionBy(int n)
    {
        num += n;
        numText.text = num.ToString();
    }
}
