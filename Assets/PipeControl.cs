using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeControl : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -10; 
    // Start is called before the first frame update
    void Start()
    {
        movePipe();
    }

    // Update is called once per frame
    void Update()
    {
        movePipe();
    }

    void movePipe()
    {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
        if(transform.position.x  <= deadZone)
        {
            Destroy(transform);
        }
    }
}
