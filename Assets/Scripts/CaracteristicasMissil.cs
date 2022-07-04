using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaracteristicasMissil : MonoBehaviour
{
    public static float pontosDeDano = 10.0f;
    [SerializeField]
    private float tempoDeVida = 5.0f;
    
    
    

    
    
    void Start()
    {
        Destroy(gameObject, tempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
