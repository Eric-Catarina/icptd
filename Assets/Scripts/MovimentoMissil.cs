using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoMissil : MonoBehaviour
{
    
    [SerializeField]
    
    private float velocidadeMissil = 10f;
    private Vector3 posicaoAtualMissil;
    private Vector3 frenteMissil;
    private Vector3 deslocamentoFrontal;
    
    private GameObject alvo;
    

    private void moveMissil(){
        posicaoAtualMissil = transform.position;
        frenteMissil = transform.forward;
        deslocamentoFrontal = frenteMissil * velocidadeMissil * Time.deltaTime;
        transform.position = posicaoAtualMissil + deslocamentoFrontal;
    }

    private void alteraDirecao(){
        Vector3 direcaoDoMissil = transform.position;
        Vector3 direcaoDoInimigo = alvo.transform.position;
        Vector3 novaDirecao = direcaoDoInimigo - direcaoDoMissil;
        transform.rotation = Quaternion.LookRotation (novaDirecao);
    }

    private void setaAlvo()
    {
        alvo = GameObject.FindGameObjectWithTag("InimigoTag");
    }

    


    void Start()
    {
        setaAlvo();
    }

    // Update is called once per frame
    void Update()
    {
        moveMissil();
        alteraDirecao();
        
        
    }
}
