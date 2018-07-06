using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hurt : MonoBehaviour
{
    public int health = 3;
    bool check = false;
    public int score = 0;

    Scene currentScene;

    public SwitchLight lightClass = new SwitchLight();

    // Use this for initialization
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (other.gameObject.tag == "light")
            {
                Debug.Log("Collided with light");
                lightClass.SetLight2On();
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("collided");
        if (health < 1)
        {
            if (currentScene.name == "level 1")
            {
                transform.position = new Vector3(24.3f, 0.925f, -24.387f);
            }
            else if (currentScene.name == "level 2")
            {
                transform.position = new Vector3(0.4f, 0.7f, -125);
            }
            health = 4;
        }
        {
            if (other.gameObject.tag == "button")
            {
                score++;
                if (score == 2)
                {
                    Debug.Log("scene transition?");
                    SceneManager.LoadScene("level 2");
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (health > 0 && other.gameObject.tag != "button")
        {
            health--;

        }
    }
}