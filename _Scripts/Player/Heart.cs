using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
   
   public int x;
     public float countdown = 1.0f;
       public float speed = 0.3f;
     public int contador;
     public CameraShake camerashake;
         public AudioSource corey;
          public AudioSource rumbling;
         public ParticleSystem blood;

          
         

        

    private void OnCollisionEnter(Collision collision)
    {





        if (collision.gameObject.CompareTag("bullet"))
        {


             gameObject.SetActive(false);

             Invoke("startCountdown",0.7f);
             Invoke("startSound",0.2f); //el tiempo de la animacion
            
 
             blood.Play();

            
             

        }
    }

  void startCountdown(){

         camerashake.shakeDuration=camerashake.shakeDuration+2.5f;

          
              

      }


      void startSound(){


         

           corey.Play();
           rumbling.Play();

        



      }


    

  
    

   
 
}
