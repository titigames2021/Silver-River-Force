using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class GameManagerMenu : MonoBehaviour
{

    public GameObject options;
     public GameObject key;
    public GameObject optionsFirst;
      public GameObject keyFirst;
    public GameObject mainMenu;
    public GameObject mainMenuFirst;


  

    public bool isOption;
    public bool main;
    // Start is called before the first frame update
    void Start()
    {
        options.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isOption)
        {

            mainMenu.gameObject.SetActive(false);
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                options.gameObject.SetActive(false);
                mainMenu.gameObject.SetActive(true);
                isOption = false;
                


                //clear selected object
                EventSystem.current.SetSelectedGameObject(null);

                //set a new selected object
                EventSystem.current.SetSelectedGameObject(mainMenuFirst);

            }
        }
    }



    

    public void backtoOption()
    {
       
        options.gameObject.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(optionsFirst);

    }


    public void StartMission()
    {
        SceneManager.LoadScene("mission");
        Time.timeScale = 1;

    }

     public void Options()
    {
        options.gameObject.SetActive(true);
        isOption = true;

        

        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(optionsFirst);

    }

   
    public void goMainMenu()
    {
        isOption = false;
        
        options.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
        

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(mainMenuFirst);

    }


     public void goKey()
    {
        isOption = false;
        
        options.gameObject.SetActive(false);
        key.gameObject.SetActive(true);
        

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(keyFirst);

    }

    
    
     public void exitKey()
    {
        options.gameObject.SetActive(true);
        isOption = true;
         key.gameObject.SetActive(false);
        

        EventSystem.current.SetSelectedGameObject(null);

        EventSystem.current.SetSelectedGameObject(optionsFirst);

    }




    public void ExitGame()
    {

        Application.Quit();
    }
    

}
