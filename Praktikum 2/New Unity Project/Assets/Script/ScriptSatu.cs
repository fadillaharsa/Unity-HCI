using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//tambahkan library UnityEngine.UI agar kita dapat mengambil textnya

public class ScriptSatu : MonoBehaviour
{
    Text iniText;
    public float waktu = 0;

    // Start is called before the first frame update
    void Start()
    {
        iniText = GameObject.Find("TextAdik").GetComponent<Text>();
        //"TextAdik" samakan dengan nama text yang kita buat di hirarki
    }

    // Update is called once per frame
    void Update()
    {
        iniText.text = "Waktu:" + waktu.ToString("");
        waktu += Time.deltaTime;
    }
}