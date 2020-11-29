using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tempo : MonoBehaviour
{
    public Text display;
    //public Text score;
    public float contagem = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        contagem+=Time.deltaTime;
        display.text = contagem.ToString("0");
    }
}
