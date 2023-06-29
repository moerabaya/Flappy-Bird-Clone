using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    LogicManager logic;

    private void Awake()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(logic.isAlive && logic.gameStarted)
        {
            if(timer < spawnRate)
            {
                timer += Time.deltaTime;
            } else
            {
                spawnPipe();
                timer = 0;
            }
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
