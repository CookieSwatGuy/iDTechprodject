using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Healthbar : MonoBehaviour
{
    public Image healthBar;
    private float initialWidth;

    // Use this for initialization
    void Start()
    {
        initialWidth = healthBar.transform.localScale.x;
    }

}