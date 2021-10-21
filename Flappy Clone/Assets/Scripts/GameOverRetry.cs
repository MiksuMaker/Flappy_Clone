using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverRetry : MonoBehaviour
{

    public GameManager gameManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            gameManager.Replay();
        }
    }
}
