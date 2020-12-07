using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carregavalor1 : MonoBehaviour
{
    public float ponto1;
    //public static float points1;
    public static float reponto1;
    public static float tempo1;
    public static bool isend1;

    public Image estrela1_1;
    public Image estrela2_1;
    public Image estrela3_1;
    // Start is called before the first frame update
    void Start()
    {
        ponto1 = passavalores1.points1;

        isend1 = passavalores1.isend;

        
        //tempo1 = passavalores1.tempos;
    }

    // Update is called once per frame
    void Update()
    {
        
        reponto1 = ponto1;

        if(isend1){
            if(reponto1 == 1 && isend1){
                estrela1_1.GetComponent<Image>().enabled = true;
            }else if(reponto1 == 2 && isend1){
                estrela1_1.GetComponent<Image>().enabled = true;
                estrela2_1.GetComponent<Image>().enabled = true;
            }else if(reponto1 == 3 && isend1){
                estrela1_1.GetComponent<Image>().enabled = true;
                estrela2_1.GetComponent<Image>().enabled = true;
                estrela3_1.GetComponent<Image>().enabled = true;
            }
            isend1 = false;
        }
    }
}
