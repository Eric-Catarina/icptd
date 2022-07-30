using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisaoMissilUm : MonoBehaviour
{
    [SerializeField]
    private SonsManager managerDeSons;
    
    private void OnTriggerEnter(Collider objetoColidido){
            managerDeSons.tocaSomHit();
            Destroy(this.gameObject);
        }
    
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
