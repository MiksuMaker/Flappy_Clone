using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    [SerializeField] public GameObject gameStartCanvas;
    public Animator canvasAnimator;
    [SerializeField] public GameObject pipeSpawner;
    [SerializeField] public GameObject scoreText;
    [SerializeField] public GameObject playerBird;
    private Rigidbody2D rb;

    public int numberOfTimesGameHasBegun;

    public bool hasGameBegunForTheFirstTime = false;

    private void Awake()
    {


        //SetUpSingleton();

        //gameStartCanvas = GameObject.Find("Start Game Canvas");
        //pipeSpawner = GameObject.Find("SPAWNER");
        //scoreText = GameObject.Find("Score Text");
        //playerBird = GameObject.Find("PlayerBird");

        //if (!hasGameBegunForTheFirstTime)
        //{
        //    PrepareFirstGame();
        //}

        PrepareFirstGame();

    }

    private void PrepareFirstGame()
    {
        canvasAnimator = gameStartCanvas.GetComponent<Animator>();
        pipeSpawner.SetActive(false);
        rb = playerBird.GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
    }

    private void SetUpSingleton()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {

            DontDestroyOnLoad(gameObject);

        }
    }


    void Update()
    {
        //Alla oleva on ehkä turhan resurssisyöppö ratkaisu...
        if (!hasGameBegunForTheFirstTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gameStartCanvas.SetActive(false);
                pipeSpawner.SetActive(true);
                rb.gravityScale = 0.6f;

                hasGameBegunForTheFirstTime = true;

                Debug.Log("Game has become for the first time: " + hasGameBegunForTheFirstTime);
            }
        }
    }
}
