using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotamenu : MonoBehaviour
{
    public float speed = 20;
    public float movimentoesq = 1;
    public float movimentodir = 1;

    public bool vai = false;
    public bool vai2 = false;
    public bool vai3 = false;
    public bool vai4 = false;

    public Transform ponto1;
    public Transform ponto2;
    public Transform ponto3;
    public Transform ponto4;

    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(Input.GetButton("Jump")){
            speed = 5;
        }else{
            speed = 20;
        }

        if (transform.position == ponto1.transform.position){
            vai = true;
        }

        if (transform.position == ponto2.transform.position){
            vai2 = true;
        }

        if (transform.position == ponto3.transform.position){
            vai3 = true;
        }

        if (transform.position == ponto4.transform.position){
            vai4 = true;
        }

        if(vai){
        transform.position = Vector3.MoveTowards(transform.position, ponto2.transform.position, speed * Time.deltaTime);
            if(transform.position == ponto2.transform.position){
                vai = false;
            }
        }

        if(vai2){
        transform.position = Vector3.MoveTowards(transform.position, ponto3.transform.position, speed * Time.deltaTime);
            if(transform.position == ponto3.transform.position){
                vai2 = false;
            }
        }

        if(vai3){
        transform.position = Vector3.MoveTowards(transform.position, ponto4.transform.position, speed * Time.deltaTime);
            if(transform.position == ponto4.transform.position){
                vai3 = false;
            }
        }

        if(vai4){
        transform.position = Vector3.MoveTowards(transform.position, ponto1.transform.position, speed * Time.deltaTime);
            if(transform.position == ponto1.transform.position){
                vai4 = false;
            }
        }  
        
    }
}
