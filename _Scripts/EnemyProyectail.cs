using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProyectail : MonoBehaviour
{

    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);

        if (gameObject.transform.position.z >= 380 || gameObject.transform.position.z <= 60)
        {

            gameObject.SetActive(false);
        }
    }
}
