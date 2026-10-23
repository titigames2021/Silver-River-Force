using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullets : MonoBehaviour
{

    float speed = 20;
    GameObject ship;
  
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);


        //if(gameObject.transform.position.z >= 1000 || gameObject.transform.position.z <= -10000)
        {

          //  gameObject.SetActive(false);
        }

        
    }


     


    //  public void OnTriggerEnter(Collider other)
    //  {

          


    //      if (other.gameObject)
    //      {

    //         gameObject.SetActive(false);
    //    }






    // }


    
    private void OnCollisionEnter(Collision collision)
    {

       





        if(collision.gameObject )
        {
             gameObject.SetActive(false);

        }

        

    }




}
