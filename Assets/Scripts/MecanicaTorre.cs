using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class MecanicaTorre : MonoBehaviour
{
    [SerializeField]
    public enum EstadoAtual
    {
        SemAlvo,
        Atirando
    };

    [SerializeField]
    public EstadoAtual estadoAtual;
    
    [SerializeField]
    private GameObject prefabMissil;
    private float momentoDoUltimoDisparo;
    [SerializeField]
    private float tempoDeRecarga = 1f;
    Vector3 posicaoPontoDisparo;
    [SerializeField]
    private Transform pontoDoDisparo;
    private GameObject inimigoAlvo;
    [SerializeField]
    private float raioDeAlcance;

    private bool temInimigos()
    {
        if (GameObject.FindGameObjectWithTag("InimigoTag"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    
    private void Atira(Enemy inimigoAlvo)
    {
        
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
        MovimentoMissil MovimentoMissilAtualScript = instanciaMissilAtual.GetComponent<MovimentoMissil>();
        MovimentoMissilAtualScript.setaAlvo(EscolheAlvo());
        
    }
    
    private bool EstaNoRaioDeAlcance(GameObject inimigo) {
        Vector3 posicaoDoInimigoNoPlano =
            Vector3.ProjectOnPlane(inimigo.transform.position, Vector3.up);
        Vector3 posicaoDaTorreNoPlano =
            Vector3.ProjectOnPlane(this.transform.position, Vector3.up);
        float distanciaParaInimigo =
            Vector3.Distance (posicaoDaTorreNoPlano, posicaoDoInimigoNoPlano);

        return distanciaParaInimigo <= raioDeAlcance;
    }

    public Enemy EscolheAlvo(){
        GameObject[] inimigos =
            GameObject.FindGameObjectsWithTag("InimigoTag");
        foreach (GameObject inimigo in inimigos) {
            if (EstaNoRaioDeAlcance(inimigo)){
                return inimigo.GetComponent<Enemy>();
            }
        }
        return null;
    }


    void Start()
    {
        estadoAtual = EstadoAtual.SemAlvo;
        
        posicaoPontoDisparo = pontoDoDisparo.transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (estadoAtual != EstadoAtual.Atirando)
        {
            if (temInimigos())
            {
                estadoAtual = EstadoAtual.Atirando;
            }
        }
        
        if (estadoAtual == EstadoAtual.Atirando && !temInimigos())
        {
            estadoAtual = EstadoAtual.SemAlvo;
        }

        if (estadoAtual == EstadoAtual.Atirando)
        {
            Atira(EscolheAlvo());
        }
        
    }
}
