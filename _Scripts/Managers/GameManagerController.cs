using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameMAnagerController : MonoBehaviour
{

  public float wait; 

   

    // Update is called once per frame
    void Update()
    {
          

        //  wait= wait + 1*Time.deltaTime;




        // if (wait >= 4.0){

        //   SceneManager.LoadScene("mission");

        // }
           

           Invoke("StartMenu",2.6f);
      
    }



      public void StartMenu()
    {
        SceneManager.LoadScene("mainMenu");
        Time.timeScale = 1;
        

    }

    
    



}
