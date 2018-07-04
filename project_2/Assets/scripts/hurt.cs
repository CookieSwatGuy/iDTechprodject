using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurt : MonoBehaviour
{
    public int health = 4;
    bool check = false;
    public int score = 0;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("IncreaseScore", 10, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (health < 1)
        {
            transform.position = new Vector3(25, 0.5f, -25);
            health = 4;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (health > 0)
        {
            health--;

        }
    }
    void IncreaseScore()
    {
        score++;
    }
}