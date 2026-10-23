using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2Control : MonoBehaviour
{
    

    public float speed = 120;

  


    
    public bool secondmove;
    public bool thirdmove;
    public bool fourthmove;
    public bool fifthmove;
    public bool firstmove;



    // Start is called before the first frame update
    void Start()
    {
        firstmove = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (firstmove)
        {
            movedown();
            moveRight();


        }

        if(gameObject.transform.position.y <= 520 && firstmove)
        {

            firstmove = false;
            secondmove = true;

        }

        if (secondmove)
        {
            moveleft();



        }

        if(gameObject.transform.position.x <= 800 && secondmove)
        {
            secondmove = false;
            thirdmove = true; 

        }

        if (thirdmove)
        {
            moveRight();
            moveup();

        }

        if(gameObject.transform.position.y >= 1177 && thirdmove)
        {
            thirdmove = false;
            fourthmove = true;



        }

        if (fourthmove)
        {
            movedown();
            moveRight();

        }


        if(gameObject.transform.position.y <=520 && fourthmove)
        {
            fourthmove = false;
            secondmove = true;

        }





    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {

            Destroy(gameObject);

        }
    }



    void moveRight()
    {


        gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }




    void movedown()
    {

        gameObject.transform.Translate(Vector2.down * speed * Time.deltaTime);

    }
    void moveup()
    {

        gameObject.transform.Translate(Vector2.up * speed * Time.deltaTime);

    }
    void moveleft()
    {

        gameObject.transform.Translate(Vector2.left * speed * Time.deltaTime);

    }
}
