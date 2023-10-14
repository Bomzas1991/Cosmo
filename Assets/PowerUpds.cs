using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerUpds : MonoBehaviour
{
    TextMeshPro bullets;

    private void Start()
    {
        bullets = GameObject.Find("Bullets").GetComponent<TextMeshPro>();
    }

    public void plus3bullets()
    {
        int bulelts;

        bulelts = int.Parse(bullets.text);
        bulelts += 3;
        bullets.text = bulelts.ToString();
    }
}
