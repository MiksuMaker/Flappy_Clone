using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;

    public bool stillAlive;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        stillAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && stillAlive)
        {
            rb.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        stillAlive = false;
        gameManager.GameOver();
    }
}
