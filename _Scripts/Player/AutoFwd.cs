using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFwd : MonoBehaviour
{
    public GameObject exit;
    public float speed = 1f;
    Vector3 tpposition;
    public GameObject tpExit;
    public bool tepeando;
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward* Time.deltaTime * speed);
       
    }



    public void OnTriggerEnter(Collider other)
    {
       
    }
}


