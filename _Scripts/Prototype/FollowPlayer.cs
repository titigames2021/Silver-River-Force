using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;

    Vector3 offset = new Vector3(0, 20, -60);
  

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = (player.gameObject.transform.position + offset);


        


    }



    
}
