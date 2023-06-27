using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public int flapStength = 6;
    public LogicManager logic;
    public bool isAlive = true;
    public AudioSource flapSource;
    public AudioClip flapClip;
    public AudioClip hitClip;
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
        if(Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            rigidbody2D.velocity = Vector2.up * flapStength;
            flapSource.PlayOneShot(flapClip);
        }

        if(transform.position.y > 6 || transform.position.y < -6)
        {
            isAlive = false;
            logic.showGameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(isAlive)
        {
            flapSource.PlayOneShot(hitClip);
            isAlive = false;
            logic.showGameOver();
        }
    }
}
