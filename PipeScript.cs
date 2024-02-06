using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(BirdScript.gameRunning==true)
        {
            transform.Translate(0.03f, 0, 0);
            if (transform.position.x <= -5.1f)
            {
                Vector2 v = transform.position;
                v.x = 14f; //distance farther than third pipe to give equal interval
                v.y = Random.Range(3.92f,7.75f);
                transform.position = v;
            }
        }
    }  

}
