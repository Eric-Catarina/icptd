using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoMissil : MonoBehaviour
{
    
    [SerializeField]
    private float velocidadeMissil = 20f;
    private Vector3 posicaoAtualMissil;
    private Vector3 frenteMissil;
    private Vector3 deslocamentoFrontal;
    
    private Enemy alvo;
    

    private void moveMissil(){
        posicaoAtualMissil = transform.position;
        frenteMissil = transform.forward;
        deslocamentoFrontal = frenteMissil * velocidadeMissil * Time.deltaTime;
        transform.position = posicaoAtualMissil + deslocamentoFrontal;
    }

    private void alteraDirecao(){
        if (alvo != null)
        {
            Vector3 direcaoDoMissil = transform.position;
            Vector3 direcaoDoInimigo = alvo.transform.position;
            Vector3 novaDirecao = direcaoDoInimigo - direcaoDoMissil;
            transform.rotation = Quaternion.LookRotation(novaDirecao);
        }
    }

    public void setaAlvo(Enemy alvo)
    {
        this.alvo = alvo;
    }

    


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveMissil();
        alteraDirecao();
        
        
    }
}
