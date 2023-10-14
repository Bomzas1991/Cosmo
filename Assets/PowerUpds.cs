using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class PowerUpds : MonoBehaviour
{
    TextMeshPro bullets;
    
    TextMeshPro liVes;

    //MeteorScript doublePoints;
    //public bool doublePoints;
    TextMeshPro doublePoints;

    BulletScript bulletSpeed;
    public GameObject bullet;

    public GameObject PowerUps;

    private void Start()
    {
        bullets = GameObject.Find("Bullets").GetComponent<TextMeshPro>();
        liVes = GameObject.Find("lives").GetComponent<TextMeshPro>();
        doublePoints = GameObject.Find("Points").GetComponent<TextMeshPro>();
    }

    private void Update()
    {
        //int point = int.Parse(doublePoints.text);

        ////doublePoints = GameObject.FindWithTag("Meteor").GetComponent<MeteorScript>();
        //if (point == 50)
        //{
        //    gameObject.SetActive(true);
        //    point = 0;
        //}
    }

    public void plus3bullets()
    {
        PowerUps.SetActive(false);

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

    public void DoublePoints()
    {
        //doublePoints.PointsToGet *= 2;
        int score;

        score = int.Parse(doublePoints.text);
        score *= 2;
        doublePoints.text = score.ToString();

        
    }

    public void FasterBullets()
    {
        bulletSpeed = bullet.GetComponent<BulletScript>();

        bulletSpeed.speed = 20;
    }
}
