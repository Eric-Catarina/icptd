using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeInimigos : MonoBehaviour
{
    
    [SerializeField]
    private GameObject inimigo;
    
    [SerializeField]
    private float momentoDaUltimaGeracao, contadorInimigosSpawnados = 0, numeroDeInimigosNaWave = 20;

    [Range(0,3)]
    [SerializeField] private float tempoDeCriacao = 2f;
    
    private void GeraInimigo () {
        float tempoAtual = Time.time;
        if (tempoAtual > momentoDaUltimaGeracao + tempoDeCriacao && contadorInimigosSpawnados<numeroDeInimigosNaWave){
           momentoDaUltimaGeracao = tempoAtual;
           Vector3 posicaoDoGerador = this.transform.position;
           Instantiate (inimigo, posicaoDoGerador,
           Quaternion.identity);
           contadorInimigosSpawnados ++;
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        GeraInimigo ();
    }
}
