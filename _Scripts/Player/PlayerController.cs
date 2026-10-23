using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{


         //luz fuera 

         public bool sunON = true;
       
        //  public Ligth _Ligth;
   
    

    public GameObject sun;
    public GameManager gameManager;






    //Moving Spikes
    public GameObject first;
     public GameObject second;
     public GameObject third;
       public GameObject fourth;
     public GameObject fifth;
    public float speedspikes=0.2f;

     public bool runnn;








    public Shields _shields;

    public Fade _fade;
    public LigthsOn _LigthsOn;
   
    

    public float rotateSpeed = 30;
    public float xySpeed = 18;
    public float maydayspeed = 0.01f; 

    public float horizontalImput;
    public float verticalImput;

    public float zspeed;

    public GameObject bullet;
    public GameObject trigger;


    public GameObject bomb;
    Vector3 bombPos = new Vector3(0, -0.08f, 0);




    bool roll;

    public float audiovolume = 1;


   

  

  




    public float coolDown = 0.6f;
    public float coolDownTimer;


    



    public int count = 0;
    public ParticleSystem hit1;
    public ParticleSystem hit2;
    public ParticleSystem hit3;


    public int life = 3;




    Animator _animator;

    Rigidbody _rb;

   public bool coolk;


    public GameObject gameOverFirstButton;



    //limits 


    public float leftlimit = 15.533f;
    public float rigthlimit = 10.632f;
    float downlimit = -1.3f;
    float uplimit = 1.118f;

    bool mayday;

    float deathtime;

    

    public AutoFwd autofwd;


    public AudioClip laserSound, crashSound, deathSound, boostsound;
    public AudioSource crash;
    public AudioSource fire;
     public AudioSource boostaudio;
    public AudioSource death;


    //tp
    public GameObject tpExit;
    public GameObject PlayerGroup;


    public bool mayday2;
    public float maydayspeed2 = 8f;
    public float deadtime2;

    public bool shoot = true;
    public bool shoot2;

    public float bulletCoolDown;
    public bool cantshoot;
    public bool firstShoot;

    public bool boostime = false;

    public bool boostimetwo = false;

    

    public float boostcount;
    public float boostcountwo;


    public float multspeed = 15;
    public float normalspeed;
  
    public GameObject boost3;
    public GameObject boost4;
   
    
     Gamepad gamepad;

  void Awake(){

    gamepad = new Gamepad();


    //   gamepad = new gamepad();
    //   gamepad.Gameplay.shoot.performed += ctx => Gshoot();

  }



   void Gshoot(){

    Debug.Log("conchetumae");

    //  Instantiate(bullet, trigger.transform.position, gameObject.transform.rotation * Quaternion.Euler(0f, 90f, 0f));

    //         fire.PlayOneShot(laserSound);

            
    //         firstShoot = true;


   }

  


    void Start()
    {
         normalspeed = autofwd.speed;

         
        Cursor.lockState = CursorLockMode.Locked;
         
    }

    // Update is called once per frame
    void Update()
    {

         Debug.Log(Input.GetAxis("BOOST"));
          Debug.Log(Input.GetAxis("BOOSTA")+"a");
      gamepad.Gameplay.Shoot.started += ctx => Gshoot();

       if(sunON==false){

        sun.SetActive(false);

       }
       else{
        sun.SetActive(true);
       }





        if(runnn==true){
 
        //  GameObject.Find("LLigth").GetComponent<Light>().range = 17;
          _LigthsOn.Invoke("moreIntensity",0.2f);
         
         
        

             

         
         
                
                                
        }



        

        _rb = gameObject.GetComponent<Rigidbody>();
        _animator = gameObject.GetComponent<Animator>();
       



        horizontalImput = Input.GetAxis("Horizontal");
        verticalImput = Input.GetAxis("Vertical");

       

        

       if(life > 0)
        {
            LocalMove(horizontalImput, verticalImput, xySpeed);


        }


        


        /*

         if (transform.localPosition.x < leftlimit)
         {

             transform.localPosition = new Vector3(leftlimit, transform.localPosition.y, transform.localPosition.z);


         }


         if(transform.localPosition.x > rigthlimit)
         {

             transform.localPosition = new Vector3(rigthlimit, transform.localPosition.y, transform.localPosition.z);


         }



         if (transform.localPosition.y > uplimit)
         {

             transform.localPosition = new Vector3(transform.localPosition.x, uplimit, transform.localPosition.z);


         }


         if (transform.localPosition.y < downlimit)
         {

             transform.localPosition = new Vector3(transform.localPosition.x, downlimit, transform.localPosition.z);


         }

         */
        if (coolk)
        {
            _rb.isKinematic = true;
        }


        if (!coolk)
        {
            _rb.isKinematic = false;
        }
        

      


        
       
        if (coolDownTimer > 0)
        {

            coolDownTimer -= Time.deltaTime;

        }

        if(coolDownTimer < 0)
        {


            coolDownTimer = 0;
            coolk = false;
        }



        if(coolDownTimer == coolDown)
        {
            coolDownTimer = 0;
           

        }


        if (gameManager.end)
        {

            shoot = false;
            
        }

       

        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown("3") ) && shoot  )
        {

            Instantiate(bullet, trigger.transform.position, gameObject.transform.rotation * Quaternion.Euler(0f, 90f, 0f));

            fire.PlayOneShot(laserSound);

            
            firstShoot = true;

        }


        if ((Input.GetAxis("BOOST") >=1 || Input.GetAxis("BOOSTA") >=1 || Input.GetKeyDown(KeyCode.Space) ) && boostimetwo==false  )
        {
            boostime = true;

            boostaudio.PlayOneShot(boostsound);
           boost3.SetActive(true);
           boost4.SetActive(true);
            
                         
           
            
          
        }

       if(Time.timeScale==0){

                   boostimetwo=true;
                   shoot=false;
                     
                     Cursor.lockState = CursorLockMode.None;

               Debug.Log("none");
       } else{
               
                 shoot=true;
                  Cursor.lockState = CursorLockMode.Locked;
               
   Debug.Log("capolla");

       }





        if (boostime)
        {
            
                boostcount += Time.deltaTime;
                
                autofwd.speed = multspeed;
                
              
              
            
        }
        else { autofwd.speed = normalspeed; }

        if (boostcount >= 0.3f)
        {
            boostimetwo= true;
            boostime = false;
            boostcount = 0;
             boost3.SetActive(false);
           boost4.SetActive(false);
          
             
        }

        if (boostimetwo)
        {
            boostcountwo += Time.deltaTime;

            if (boostcountwo >= 1.5f)
            {
                boostimetwo = false;
                boostcountwo = 0;
            }


        }


        if (firstShoot)
        {

            bulletCoolDown += Time.deltaTime;
        }
        
        if(bulletCoolDown > 0  )
        {

            shoot = false;
        }

        if(bulletCoolDown > 0.3)
        {
            shoot = true;
            bulletCoolDown = 0;
            firstShoot = false;

        }



        if (life <= 0)
        {

            gameManager.GameOver();

            _animator.SetTrigger("Death");

            mayday = true;

            Time.timeScale = 0.5f;

            death.Play();
            




        }


        if (PlayerGroup.transform.position.z >= 515)
        {
            gameManager.EndGame();

            

            mayday2 = true;

            Time.timeScale = 0.5f;


        }





        if (mayday)
        {
            transform.localPosition -= new Vector3( 0.5f,0.5f) *maydayspeed *Time.deltaTime;

            deathtime += Time.deltaTime;
        }

        if (mayday2)
        {
            gameObject.transform.Translate(Vector3.left * maydayspeed2 * Time.deltaTime);


            deadtime2 += Time.deltaTime;
        }


        if (deathtime >= 1)
        {
            gameObject.SetActive(false);
            autofwd.speed = 0;

        }

        if (deadtime2 >= 1)
        {
            gameObject.SetActive(false);
            autofwd.speed = 0;

        }


        //powerligths
        




    }

    

    void LocalMove(float x, float y, float speed)
    {
        transform.localPosition += new Vector3(x, y, 0) * speed * Time.deltaTime;

        Limits();



    }

    void Limits()
    {

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        pos.x = Mathf.Clamp01(pos.x);
        pos.y = Mathf.Clamp01(pos.y);
        transform.position = Camera.main.ViewportToWorldPoint(pos);



    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fade"))
        {
            
            _fade.Invoke("FadeInOut", 0);
            
            

        }


        if(other.gameObject.CompareTag("sunon")){



             sunON=true;

        }

        if (other.gameObject.CompareTag("TpEntry"))
        {
            _LigthsOn.Invoke("Ligths", 1);

            PlayerGroup.transform.position = tpExit.transform.position;
           

             sunON =false;


        }

         if(other.gameObject.CompareTag("Start")){


                    runnn = true;
                   
             
             _LigthsOn.Invoke("moreIntensity", 0.3f);





            }



    }


     

    


    private void OnCollisionEnter(Collision collision)
    {

       





        if(collision.gameObject && coolDownTimer == 0 && life > 0)
        {
            //gameManager.ReduceLife(1);
            _shields.DestroyShields();
            life--;
            coolDownTimer = coolDown;

            _animator.SetTrigger("Crash");

            coolk = true;

            crash.Play();

        }

        

    }


    







}
