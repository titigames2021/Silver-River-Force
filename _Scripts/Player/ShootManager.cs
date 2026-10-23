using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootManager : MonoBehaviour
{

    public GameObject bullet;
    public float timeshoot = 0.5f;
     public float timeNextShoot = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shoot", timeshoot, timeNextShoot);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void shoot()
    {

        Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);

    }
}
