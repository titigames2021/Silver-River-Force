using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerControl : MonoBehaviour
{

    public float time;

    

    // Update is called once per frame
    void Update()
    {


        time += Time.deltaTime;


        if(time >= 6.5f)
        {
            SceneManager.LoadScene("mainMenu");


        }



    }
}
