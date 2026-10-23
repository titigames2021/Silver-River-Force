using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereObstacle : MonoBehaviour
{

    public float speed = 0.3f;
    public float angleOfRotation = 0.2f;


    public string tag;

    public PlayerController playc;

    // Update is called once per frame
    void Update()
    {




         if(playc.runnn && CompareTag("first") ){

            moveLeft();
         }




           if(CompareTag("UpBack")){


           
            moveUp();
           moveBack();
         
        }




             if(CompareTag("Down")){

                      moveDown();


             }
       










          
       





        
        if(CompareTag("Right")){


           
          moveRight();
        }
       


        if(CompareTag("Left")){


           
            moveLeft();
        }




        


        

        if (CompareTag("Back"))
        {

            moveBack();
            //moveRight();
            //movedown();
           

        }


        if (CompareTag("LDown"))
        {

            moveLeft();
            moveDown();
         

        }





        if (CompareTag("BRight"))
        {

             moveBack();
             moveRight();
         
        

        }



    }


 void moveForward()
    {


        gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void moveRight()
    {


        gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void moveBack()
    {


        gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);
    }


    void moveDown()
    {

        gameObject.transform.Translate(Vector2.down * speed * Time.deltaTime);

    }
    void moveUp()
    {

        gameObject.transform.Translate(Vector2.up * speed * Time.deltaTime);

    }
    public void moveLeft()
    {

        gameObject.transform.Translate(Vector2.left * speed * Time.deltaTime);

    }
        //  DA PROBLEMAS ASI QUE LO DEJAMOS POR MOMENTO
    void rotate()
     {
         gameObject.transform.Rotate(Vector3.left * angleOfRotation * Time.deltaTime);
     }

   

}
