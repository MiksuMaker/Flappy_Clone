using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyScript : MonoBehaviour
{
    public GameManager gameManager;
    [SerializeField] AudioClip jumpSound;
    [SerializeField] float jumpVolyme = 1f;
    [SerializeField] AudioClip deathSound;
    [SerializeField] float deathVolyme = 1f;

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
            AudioSource.PlayClipAtPoint(jumpSound, Camera.main.transform.position, jumpVolyme);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        stillAlive = false;
        gameManager.GameOver();
        AudioSource.PlayClipAtPoint(deathSound, Camera.main.transform.position, deathVolyme);
    }
}
