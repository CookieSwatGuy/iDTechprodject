using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLight : MonoBehaviour
{
    public GameObject light1;
    public GameObject light2;


	// Use this for initialization
	void Start ()
    {
        light1.SetActive(true);
        light2.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    public void SetLight2On ()
    {
        light1.SetActive(false);
        light2.SetActive(true);
    }
}
