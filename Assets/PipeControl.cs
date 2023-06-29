using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeControl : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -12;
    LogicManager logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
        movePipe();
    }

    // Update is called once per frame
    void Update()
    {
        movePipe();
    }

    void movePipe()
    {
        if(logic.isAlive && logic.gameStarted)
        {
            transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
            if(transform.position.x <= deadZone)
            {
                Destroy(gameObject);
            }
        }
    }
}
