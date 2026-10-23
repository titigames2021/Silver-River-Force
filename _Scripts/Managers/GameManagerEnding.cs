using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerEnding : MonoBehaviour
{

   
   Animator _animatorLuz;
    Animator _animatorMoon;
     Animator _animatorSun;
     Animator _animator1;
    Animator _animator2;
     Animator _animator3;

    public GameObject credits1;
    public GameObject credits2;
    public GameObject credits3;


    public GameObject Sun;
    public GameObject Moon;
    public GameObject Luz;





      public ParticleSystem PY1;
       public ParticleSystem PY2;
        public ParticleSystem PY3;
         public ParticleSystem PY4;

         public AudioClip  explosion;
             public AudioSource sourcexplo;
    
    // Start is called before the first frame update
   
   
   void Awake(){
      Invoke("Movemoon",0.1f);
      sourcexplo.PlayOneShot(explosion);

   }
   
   
   
    void Start()
    {
         _animatorLuz= Luz.GetComponent<Animator>();
        _animatorMoon = Moon.GetComponent<Animator>();
         _animatorSun = Sun.GetComponent<Animator>();

          _animator1= credits1.GetComponent<Animator>();
        _animator2 = credits2.GetComponent<Animator>();
         _animator3 = credits3.GetComponent<Animator>();
        Invoke("Animations",2.5f);
         Invoke("PYONE",3f);
          Invoke("PYTWO",3.5f);
          Invoke("PYTHREE",5f);
           Invoke("SUNF",5f);
           Invoke("Delete",7f);
            Invoke("Gamename",8f);
             Invoke("Yoliteral",11f);
             Invoke("BReturn",13f);
              Invoke("Return",16f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
   public void Animations(){

          _animatorLuz.SetTrigger("move");
          

   }

       
   public void Gamename(){

          _animator1.SetTrigger("srf");
          

   }
    public void Yoliteral(){

          _animator2.SetTrigger("agame");
          _animator3.SetTrigger("yo");
          

   }

    public void Movemoon(){

          _animatorMoon.SetTrigger("move");
          

   }
    public void Return(){

          
          SceneManager.LoadScene("mainMenu");
          

   }

     public void BReturn(){

          
          _animatorSun.SetTrigger("close");
          

   }



    

    public void Delete(){

         Moon.SetActive(false);
      
    }
   
   public void SUNF(){

          _animatorSun.SetTrigger("flas");

   }

   public void PYONE(){

          PY1.Play();
          PY2.Play();

   }
     public void PYTWO(){

          PY3.Play();
         

   }

    public void PYTHREE(){

          PY4.Play();
         

   }



}
