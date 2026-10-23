using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEditor;


public class GameManager : MonoBehaviour
{



     public GameObject sun; 
      public GameObject  youdie; 
    

    public PlayerController player;

    //public SetVolume _setVolume;

    Animator _animator;
    Animator _animatorL;
     Animator _animatorY;

    public int life;

    public bool isDead;

    public bool isOption;

    //UI
    public GameObject gameOverPanel;
     public GameObject gameOverFirstButton;
    public GameObject gameOverSecondButton;

    public GameObject endfirst;
    public GameObject endSec;
    public GameObject endThi;

    public float timeToSpawnButtons;

    public GameObject pauseMenu;
     public GameObject pauseFirstButton;
    public GameObject pauseSecondButton;
    public GameObject optionsMenu;
     public GameObject optionsFirstButton;
    public GameObject shield;

    public GameObject eeditor;

    public GameObject fadeOut;

    public GameObject theEnd;

    public GameObject playergroup;
    public GameObject playerr;

    public Slider MasterSlider;

    public float timeEnd;
    public float timeEnd2;
     float speed = 0.8f;

    public GameObject credits;
    public GameObject creditsF;

    public bool noPause;

    public bool end;

    public bool canShoot;


    // Start is called before the first frame update
    void Start()
    {
        
        
  
        life = player.life;

        
         _animatorY = youdie.GetComponent<Animator>();
        _animatorL = sun.GetComponent<Animator>();

        _animator = player.GetComponent<Animator>();

        pauseMenu.gameObject.SetActive(false);

        gameOverPanel.gameObject.SetActive(false);

        optionsMenu.gameObject.SetActive(false);
        theEnd.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);

    }



    // Update is called once per frame
    void Update()
    {

        


       


        
      



        if (Input.GetButtonDown("exit")||Input.GetKeyDown(KeyCode.Escape) && noPause==false )
        {

           
            if(Time.timeScale == 0)
            {
                Time.timeScale = 1;
                pauseMenu.gameObject.SetActive(false);
             
                
               
            }
            else
            {
                Time.timeScale = 0;
                pauseMenu.gameObject.SetActive(true);

                //clear selected object
                EventSystem.current.SetSelectedGameObject(null);

                //set a new selected object
                EventSystem.current.SetSelectedGameObject(pauseFirstButton);

              
               
            }

           


        }

      if ( isOption)
        {
           
            pauseMenu.gameObject.SetActive(false);
            if (Input.GetButtonDown("exit")||Input.GetKeyDown(KeyCode.Escape) )
            {
                optionsMenu.gameObject.SetActive(false);
                pauseMenu.gameObject.SetActive(true);
                isOption = false;
                Time.timeScale = 0;
               

                //clear selected object
                EventSystem.current.SetSelectedGameObject(null);

                //set a new selected object
                EventSystem.current.SetSelectedGameObject(pauseFirstButton);

            }
        }

    }


    public void EndGame()
    {
        noPause = true;
        end = true;
        // theEnd.gameObject.SetActive(true);
        // optionsMenu.SetActive(false);
        // pauseMenu.SetActive(false);

        // timeEnd += Time.deltaTime;

        // endfirst.SetActive(false);
        // endSec.SetActive(false);
        // endThi.SetActive(false);

        // if (timeEnd >= 1)
        // {
        //     endfirst.SetActive(true);
        //     endSec.SetActive(true);
        //     endThi.SetActive(true);

        // }

        // //clear selected object
        // EventSystem.current.SetSelectedGameObject(null);

        // //set a new selected object
        // EventSystem.current.SetSelectedGameObject(endfirst);


       _animatorL.SetTrigger("sundie");

              Invoke("ToEnd",3f);


    }

    public void GameOver()
    {
        noPause = true;

        gameOverPanel.SetActive(true);
        optionsMenu.SetActive(false);
        pauseMenu.SetActive(false);

        // timeToSpawnButtons += Time.deltaTime;
        // gameOverFirstButton.SetActive(false);
        // gameOverSecondButton.SetActive(false);
        // if (timeToSpawnButtons >= 1)
        // {
        //     gameOverFirstButton.SetActive(true);
        //     gameOverSecondButton.SetActive(true);

        // }

        // //clear selected object
        //  EventSystem.current.SetSelectedGameObject(null);

        // //set a new selected object
        // EventSystem.current.SetSelectedGameObject(gameOverFirstButton);

        Invoke("RestartGame",3.5f);
         _animatorL.SetTrigger("sundie");
          _animatorY.SetTrigger("die");
         player.transform.Translate(Vector3.down* Time.deltaTime * speed);

        
         
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        player.gameObject.SetActive(false);
        
        

    }

    public void ToEnd(){
        SceneManager.LoadScene("final");
    }




    public void ExitMainMenu()
    {

        SceneManager.LoadScene("mainMenu");
        EventSystem.current.SetSelectedGameObject(null);
    }

    public void options()
    {
        optionsMenu.gameObject.SetActive(true);

        //clear selected object
        EventSystem.current.SetSelectedGameObject(null);

        //set a new selected object
        EventSystem.current.SetSelectedGameObject(optionsFirstButton);

        pauseMenu.gameObject.SetActive(false);

        isOption = true;
    }


    public void backToPause()
    {
       

        optionsMenu.gameObject.SetActive(false);
        pauseMenu.gameObject.SetActive(true);
        isOption = false;


        //clear selected object
        EventSystem.current.SetSelectedGameObject(null);

        //set a new selected object
        EventSystem.current.SetSelectedGameObject(pauseFirstButton);

    }

    public void Continue()
    {
        pauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
    }



    public void backToEnd()
    {


        credits.gameObject.SetActive(false);
        theEnd.gameObject.SetActive(true);
       


        //clear selected object
        EventSystem.current.SetSelectedGameObject(null);

        //set a new selected object
        EventSystem.current.SetSelectedGameObject(endfirst);

    }

    public void goToCredits()
    {


        theEnd.gameObject.SetActive(false);
        credits.gameObject.SetActive(true);
        


        //clear selected object
        EventSystem.current.SetSelectedGameObject(null);

        //set a new selected object
        EventSystem.current.SetSelectedGameObject(creditsF);

    }



}
