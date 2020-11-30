using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tempo : MonoBehaviour
{
    public Text display;
    
    public float contagem = 0f;

    public float radius = 1f;

    public Transform jogador;

    public Image estrela1;
    public Image estrela2;
    public Image estrela3;

    public Transform som1;
    public Transform som2;
    public Transform som3;

    public LayerMask ponto1;
    public LayerMask ponto2;
    public LayerMask ponto3;

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public bool pontuado1 = false;
    public bool pontuado2 = false;
    public bool pontuado3 = false;
    public float pontos = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pontuado1 = Physics2D.OverlapCircle(jogador.transform.position, radius ,ponto1);
        pontuado2 = Physics2D.OverlapCircle(jogador.transform.position, radius ,ponto2);
        pontuado3 = Physics2D.OverlapCircle(jogador.transform.position, radius ,ponto3);

        if(pontuado1){
            star1.SetActive(false);
            pontos = pontos + 1;
            pontuado1 = false;
        }

        if(pontuado2){
            star2.SetActive(false);
            pontos = pontos + 1;
            pontuado2 = false;
        }

        if(pontuado3){
            star3.SetActive(false);
            pontos = pontos + 1;
            pontuado3 = false;
        }

        if(pontos == 1){
            estrela1.GetComponent<Image>().enabled = true;
            som1.GetComponent<AudioSource>().enabled = true;
        }else if(pontos == 2){
            estrela1.GetComponent<Image>().enabled = true;
            estrela2.GetComponent<Image>().enabled = true;
            som2.GetComponent<AudioSource>().enabled = true;
        }else if(pontos == 3){
            estrela1.GetComponent<Image>().enabled = true;
            estrela2.GetComponent<Image>().enabled = true;
            estrela3.GetComponent<Image>().enabled = true;
            som3.GetComponent<AudioSource>().enabled = true;
        }

        contagem+=Time.deltaTime;
        display.text = contagem.ToString("0");
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(jogador.transform.position, radius);
    }
}
