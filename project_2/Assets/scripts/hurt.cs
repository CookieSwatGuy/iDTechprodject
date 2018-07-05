using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hurt : MonoBehaviour
{
    public int health = 4;
    bool check = false;
    public int score = 0;

    public SwitchLight lightClass = new SwitchLight();

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
        Debug.Log("collided");
        if (other.gameObject.tag == "light")
        {
            Debug.Log("Collided with light");
            lightClass.SetLight2On();
        }
        else if (health < 1)
        {
            transform.position = new Vector3(0.4f, 0.7f, -125);
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
        if (score == 10000)
        {
            Debug.Log("scene transition?");
            SceneManager.LoadScene("level 2");
        }
    }
}