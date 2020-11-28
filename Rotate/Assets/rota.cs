using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rota : MonoBehaviour
{
    public float speed = 20;
    public float movimentoesq = 1;
    public float movimentodir = 1;

    public bool vai = false;
    public bool vai2 = false;
    public bool vai3 = false;
    public bool vai4 = false;

    public bool volta = false;
    public bool volta2 = false;
    public bool volta3 = false;
    public bool volta4 = false;

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

        if (Input.GetButton("Fire1")&& transform.position == ponto1.transform.position){
            vai = true;
        }

        if (Input.GetButton("Fire1") && transform.position == ponto2.transform.position){
            vai2 = true;
        }

        if (Input.GetButton("Fire1") && transform.position == ponto3.transform.position){
            vai3 = true;
        }

        if (Input.GetButton("Fire1") && transform.position == ponto4.transform.position){
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

        //VOLTA

        if (Input.GetButton("Fire2")&& transform.position == ponto1.transform.position){
            volta = true;
        }

        if (Input.GetButton("Fire2") && transform.position == ponto4.transform.position){
            volta2 = true;
        }

        if (Input.GetButton("Fire2") && transform.position == ponto3.transform.position){
            volta3 = true;
        }

        if (Input.GetButton("Fire2") && transform.position == ponto2.transform.position){
            volta4 = true;
        }

        if(volta){
        transform.position = Vector3.MoveTowards(transform.position, ponto4.transform.position, speed * Time.deltaTime);
            if(transform.position == ponto4.transform.position){
                volta = false;
            }
        }

        if(volta2){
        transform.position = Vector3.MoveTowards(transform.position, ponto3.transform.position, speed * Time.deltaTime);
            if(transform.position == ponto3.transform.position){
                volta2 = false;
            }
        }

        if(volta3){
        transform.position = Vector3.MoveTowards(transform.position, ponto2.transform.position, speed * Time.deltaTime);
            if(transform.position == ponto2.transform.position){
                volta3 = false;
            }
        }

        if(volta4){
        transform.position = Vector3.MoveTowards(transform.position, ponto1.transform.position, speed * Time.deltaTime);
            if(transform.position == ponto1.transform.position){
                volta4 = false;
            }
        }
        
    }
}
