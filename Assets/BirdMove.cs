using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public int flapStength = 6;
    public LogicManager logic;
    public bool birdAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        moveBirdUp();
    }

    void moveBirdUp()
    {
        if(Input.GetKeyDown(KeyCode.Space) && birdAlive)
        {
            rigidbody2D.velocity = Vector2.up * flapStength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdAlive = false;
        logic.showGameOver();
    }
}
