using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public GameObject spaceship;
    

    public float acceleration = 0.5f;
    public float deceleration = 1f;

    Animator _animator;

    //lo que hay en el cerebro
    private const string _Roll = "Roll";
    private const string _Roll_B = "Roll_B";

    public bool turnRigth;
    public bool turnLeft;
    public bool noTurnLeft;
    public bool barrelL;
    public bool barrelR;

    
    //enlaces 
    public float roll_f;
    int RollHash;
  




    public bool reverseR;
    public bool reverseL;


    // para contar las veces que le doy click al input 
    public int timesClickedL;
    public int timesClickedR;

    //para permitir que se inicie la animacion
    public bool canBR;
    public bool canBL;

    //para hacer que el tiempo corra o deje de correr 
    public bool runtimeL;
    public bool runtimeR;

    // el tiempo maximo 
    public float maxTime = 0.5f;

    //el tiempo que corre 
    public float timetoBarrelRollL;
    public float timetoBarrelRollR;

    

    

    // Start is called before the first frame update
    void Start()
    {
        

        _animator = spaceship.GetComponent<Animator>();

        RollHash = Animator.StringToHash("Roll");

        
        
    }
    private void LateUpdate()
    {
        _animator.SetFloat(RollHash, roll_f);

    }
    // Update is called once per frame
    void Update()
    {
        


       
        //INPUTS
        turnRigth = Input.GetKey(KeyCode.E);
        turnLeft = Input.GetKey(KeyCode.Q);


        barrelL = Input.GetKeyDown("z");
        barrelR = Input.GetKeyDown("x");
        roll_f = Input.GetAxis("RollAxis");


        
        if (Input.GetButtonDown("Fire2") || Input.GetKeyDown("q"))
        {
            //sumar veces que le doy a la c 
            timesClickedL++;

            // hago que el tiempo corra
            runtimeL = true;
        }

        if (runtimeL)
        {
            //tiempo corriendo
            timetoBarrelRollL += Time.deltaTime;
        }

        //cuando el tiempo llege  a maxtime....
        if(timetoBarrelRollL > maxTime)
        {
            //reinicializo el tiempo a 0
            timetoBarrelRollL = 0;
            //le digo al tiempo que deje de correr
            runtimeL = false;
            //reinicializo los clicks de la c a 0 
            timesClickedL = 0;
        }
        
       //cuando le haya dado dos clicks antes de que el tiempo llege al maximo
        if(timetoBarrelRollL < maxTime  && timesClickedL ==2)
        {
            //permito que se inicie la animacion
            canBL = true;
            //reinicializo los clicks a 0 
            timesClickedL = 0;
        }

        if (canBL)
        {

            _animator.SetTrigger("Barrel_TL");
            canBL = false;
        }


        






        if (Input.GetButtonDown("Fire3") || Input.GetKeyDown("e")  )
        {
            timesClickedR++;

            runtimeR = true;

           
        }

        if (runtimeR)
        {
            timetoBarrelRollR += Time.deltaTime;
        }


        if (timetoBarrelRollR > maxTime)
        {

            timetoBarrelRollR = 0;
            runtimeR = false;
            timesClickedR = 0;
        }

        if (timesClickedR > 2)
        {

        }

        if (timetoBarrelRollR < maxTime && timesClickedR == 2)
        {
            canBR = true;

            timesClickedR = 0;
        }




        







        

        if (canBR)
        {

            _animator.SetTrigger("Barrel_TR");
            canBR = false;
        }

       




        




        





    }


    




}
