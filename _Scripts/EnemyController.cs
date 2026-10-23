using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //detectores
    public Collider detector1;
    public Collider detector2;
    public Collider detector3;
    public Collider detector4;


    //time
    public float timetoshoot;



    //ship
    public GameObject player;

    //animations

    public Animator _animator;

    //speed

    public float speed = 0.001f;



    //IA 01
    public float IA01FM01 = 7.78f, IA02FM01 = 7.75F, IA03FM01 = 7.7F, IA04FM01 = 7.75F;
    public float IA01FM02 = 8.2f, IA02FM02=8.1F, IA03FM02 =8F, IA04FM02 =8;
    public bool IA01BM01, IA01BM02, IA02BM01, IA02BM02, IA03BM02, IA03BM01, IA04BM01, IA04BM02;
    
    

    //proyectail
    public GameObject fire;
    public GameObject proyectail;
    public bool canShoot;
    public float timetospawn = 0.1f;
    public float timebtwspawn = 1f, shootspeed;

    public AudioClip snarl;
    public AudioSource shootsound;


    public float playerZ;
    

    // Start is called before the first frame update
    void Start()
    {
        IA01BM01 = true;
        IA02BM01 = true;
        IA03BM01 = true;
        IA04BM01 = true;
        canShoot = true;
        
    }

    // Update is called once per frame
    void Update()
    {

        


        if (CompareTag("feyes1"))
        {
           

           

            if (gameObject.transform.position.x < IA01FM01)
            {
                IA01BM01 = false;
                IA01BM02 = true;
               

            }


            if(gameObject.transform.position.x > IA01FM02)
            {
                IA01BM02 = false;
                IA01BM01 = true;

            }

            if (IA01BM01 == true)
            {
                moveRight();
                moveup();
            }
            if (IA01BM02 == true)
            {
                movedown();
                moveleft();
            }


            if (player.transform.position.z > 60 && player.transform.position.z < 84)
            {

                attack();

                if (canShoot == true)
                {
                    StartCoroutine(shoot());
                }

               

            }
        }


        if (CompareTag("feyes2"))
        {




            if (gameObject.transform.position.x < IA01FM01)
            {
                IA02BM01 = false;
                IA02BM02 = true;


            }


            if (gameObject.transform.position.x > IA01FM02)
            {
                IA02BM02 = false;
                IA02BM01 = true;

            }

            if (IA02BM01 == true)
            {
                moveRight();
                moveup();
            }
            if (IA02BM02 == true)
            {
                movedown();
                moveleft();
            }


            if (player.transform.position.z > 120 && player.transform.position.z < 140)
            {

                attack();

                if (canShoot == true)
                {
                    StartCoroutine(shoot());
                }



            }
        }

        if (CompareTag("feyes3"))
        {




            if (gameObject.transform.position.x < IA03FM01)
            {
                IA03BM01 = false;
                IA03BM02 = true;


            }


            if (gameObject.transform.position.x > IA03FM02)
            {
                IA03BM02 = false;
                IA03BM01 = true;

            }

            if (IA03BM01 == true)
            {
                moveRight();
                moveup();
            }
            if (IA03BM02 == true)
            {
                movedown();
                moveleft();
            }


            if (player.transform.position.z > 200 && player.transform.position.z < 220)
            {

                attack();

                if (canShoot == true)
                {
                    StartCoroutine(shoot());
                }



            }
        }

        if (CompareTag("feyes4"))
        {




            if (gameObject.transform.position.x < IA04FM01)
            {
                IA04BM01 = false;
                IA04BM02 = true;


            }


            if (gameObject.transform.position.x > IA04FM02)
            {
                IA04BM02 = false;
                IA04BM01 = true;

            }

            if (IA04BM01 == true)
            {
                moveRight();
                movedown();
            }
            if (IA04BM02 == true)
            {
                moveleft();
                
                moveup();
            }


            if (player.transform.position.z > 200 && player.transform.position.z < 220)
            {

                attack();

                if (canShoot == true)
                {
                    StartCoroutine(shoot());
                }



            }
        }






        //if (player.transform.position.z > 90)
        {
           // enemyattack = false;
        }

        //if(enemyattack == true)
        {
            
        }


    }


   public void attack()
    {
        _animator.Play("Attack");

       

       
    }



    IEnumerator shoot()
    {
        canShoot = false;
        yield return new WaitForSeconds(timebtwspawn);

        GameObject newBullet = Instantiate(proyectail, fire.transform.position, fire.transform.rotation) ;

        shootsound.PlayOneShot(snarl);

        

        newBullet.GetComponent<Rigidbody>().velocity = new Vector3(shootspeed * Time.fixedDeltaTime, 0f);
        canShoot = true;
    }

  



    void moveRight()
    {


        gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void moveBack()
    {


        gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);
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
