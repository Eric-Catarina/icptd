using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MecanicaTorre : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabMissil;
    private float momentoDoUltimoDisparo;
    [SerializeField]
    private float tempoDeRecarga = 1f;
    Vector3 posicaoPontoDisparo;
    GameObject pontoDoDisparo;
    private GameObject inimigoAlvo;

    
    
    
    private void Atira()
    {
        inimigoAlvo = GameObject.FindWithTag("InimigoTag");
        if (inimigoAlvo){

            float tempoAtual = Time.time;
            if (tempoAtual > momentoDoUltimoDisparo + tempoDeRecarga)
            {
                momentoDoUltimoDisparo = tempoAtual;
                disparaMissil();
                
            }
        }
    }
    private void disparaMissil()
    {
        GameObject instanciaMissilAtual = Instantiate(prefabMissil, posicaoPontoDisparo, transform.rotation);
        
    }

    void Start()
    {

        pontoDoDisparo = GameObject.Find("CanhaoDaTorre/PontoDeDisparo");

        posicaoPontoDisparo = pontoDoDisparo.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        Atira();
    }
}
