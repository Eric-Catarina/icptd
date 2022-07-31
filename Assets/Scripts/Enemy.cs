using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    
    public static int RetornaInimigosMortos(){
        return inimigosMortos;
    }
    [SerializeField] private SonsManager managerDeSons;
    private float pontosDeVida = 100;

    private void OnTriggerEnter(Collider objetoColidido){
        pontosDeVida -= CaracteristicasMissil.pontosDeDano;
    }
    public static int inimigosMortos = 0;
    private void hpMenorQueZero(){
        if (pontosDeVida <= 0){
            managerDeSons.tocaSomMorte();
            inimigosMortos ++;
            Destroy(this.gameObject);
        }
    }
   
    
    void Start()
    {
        UnityEngine.AI.NavMeshAgent agente = GetComponent<UnityEngine.AI.NavMeshAgent>();
        GameObject destino = GameObject.Find("FimDaPista");
        Vector3 posicaoDestino = destino.transform.position;
        agente.SetDestination(posicaoDestino);
        managerDeSons = GameObject.FindObjectOfType<SonsManager>();
        managerDeSons.tocaSomSpawn();
        

    }

    // Update is called once per frame
    void Update()
    {
        


        hpMenorQueZero();
        
    }
}
