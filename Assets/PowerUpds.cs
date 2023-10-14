using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PowerUpds : MonoBehaviour
{
    TextMeshPro bullets;
    
    TextMeshPro liVes;
    

    private void Start()
    {
        bullets = GameObject.Find("Bullets").GetComponent<TextMeshPro>();
        liVes = GameObject.Find("lives").GetComponent<TextMeshPro>();
    }

    public void plus3bullets()
    {
        int bulelts;

        bulelts = int.Parse(bullets.text);
        bulelts += 3;
        bullets.text = bulelts.ToString();
    }

    public void ExtraHeart()
    {
        int lives;

        lives = int.Parse(liVes.text);
        lives += 1;
        liVes.text = lives.ToString();
    }
}
