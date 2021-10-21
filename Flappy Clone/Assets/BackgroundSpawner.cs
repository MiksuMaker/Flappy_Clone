using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawner : MonoBehaviour
{
    // Cloned straight from the PipeSpawner


    [SerializeField] private float maxTime = 1;
    [SerializeField] private float offsetNumber = 4;
    private float timer = 0;
    public GameObject background;
    [SerializeField] private float height = 1;


    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newBG = Instantiate(background);
            newBG.transform.position = transform.position + new Vector3(offsetNumber, 0, 0);
            Destroy(newBG, 5);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
