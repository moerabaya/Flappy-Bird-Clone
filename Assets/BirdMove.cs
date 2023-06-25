using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public int flapStength = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveBirdUp();
    }

    void moveBirdUp()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.velocity = Vector2.up * flapStength;
        }
    }
}
