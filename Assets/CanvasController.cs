using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    LogicManager logic;

    private void Awake()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !logic.gameStarted)
        {
            //System.Console.WriteLine("Space Key Was Pressed!");
            logic.startGame();
        }
    }
}
