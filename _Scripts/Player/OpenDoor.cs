using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    // float speed = 1;

    public ParticleSystem explosion;
    public AudioSource wallexplosion;

    public int contador;
    


    private void OnCollisionEnter(Collision collision)
    {
        if  (collision.gameObject.CompareTag("bullet"))
        {

            contador = contador + 1;

            if(contador >= 2)
            {

                //explosion.Play();
                 gameObject.SetActive(false);

                wallexplosion.Play();

            }

            


        }

        
    }









}
