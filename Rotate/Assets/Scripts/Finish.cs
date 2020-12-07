using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{

    //public Transform player;
    public LayerMask end;
    public LayerMask tp1;

    public Transform tp2;

    public float radius = 1f;

    public bool isend = false;
    public bool teleported = false;
    public bool fase = true;

    public Transform somend;

    public GameObject score;
    public GameObject pause;
    public GameObject tempo;
    public GameObject particulas;
    public GameObject particulasend;
    public GameObject particulastp1;
    public GameObject particulastp2;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        isend = Physics2D.OverlapCircle(transform.position, radius ,end);
        //passavalores1.isend = Physics2D.OverlapCircle(transform.position, radius ,end);

        teleported = Physics2D.OverlapCircle(transform.position, radius ,tp1);

        if(teleported){
            transform.position = tp2.transform.position;
            particulastp1.SetActive(false);
            particulastp2.SetActive(false);
        }

        if(isend && fase){
            somend.GetComponent<AudioSource>().enabled = true;
            pause.SetActive(false);
            pause.GetComponent<PauseMenu>().enabled = false;
            tempo.GetComponent<Tempo>().enabled = false;
            particulasend.SetActive(false);
            particulastp1.SetActive(false);
            particulastp2.SetActive(false);
            particulas.SetActive(true);
            score.SetActive(true);
            Destroy(gameObject);
            fase = false;
            isend = false;
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}

