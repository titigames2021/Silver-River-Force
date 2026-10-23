using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Shields : MonoBehaviour
{
    public GameObject[] shields;
    public int life = 3; 
   



   



    public void DestroyShields()
    {
        life -= 1;

        shields[life+1].SetActive(false);

    }
}
