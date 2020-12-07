using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class passavalores1 : MonoBehaviour
{
    public static float points;
    public static float points1;
    public static float tempos;
    public static bool isend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(points<3){
            points1 = carregavalor1.reponto1;
        }
    }
}
