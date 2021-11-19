using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
   [SerializeField] float turnSpeed = 90f;
    //  public AudioSource tickSource;

  public SoundManager sm;
  
    
    
    void Start()
    {
        //tickSource = GetComponent<AudioSource>();

        sm = FindObjectOfType<SoundManager>();
    
    
    
    
    }
    private void OnTriggerEnter(Collider other)
     { 
        if (other.gameObject.GetComponent<Obsticle>() != null)
        {

         

           Destroy(gameObject);
           
            return;

        }
        
        
        if (other.gameObject.name != "Player") {

            return;
        }
        
        sm.Playcoin();
        Destroy(gameObject);

        GameManager.inst.IncrementScore();
     }

    void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);   
    }
}
