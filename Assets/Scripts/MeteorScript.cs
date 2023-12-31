using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class MeteorScript : MonoBehaviour
{
    public float speed;
    float timer;

    TextMeshPro points;
    int Points;
    public int PointsToGet = 1;

    //public GameObject doublePointsa;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPointQ();
        points = GameObject.Find("Points").GetComponent<TextMeshPro>();
        //doublePoint = doublePointsa.GetComponent<PowerUpds>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Vector2.zero, speed * Time.deltaTime);

        timer += Time.deltaTime;

        if (timer >= 10)
        {
            speed += 30;
            timer = 0;
        }

        //if (doublePoint.doublePoints == true)
        //{
        //    PointsToGet *= 2;
        //}
    }

    void SpawnPointQ()
    {
        float SpawnPoint = Random.Range(0, 4);

        float xPosition = Random.Range(-10, 10);
        float yPosition = Random.Range(-6, 6);

        if (SpawnPoint == 0)
        {
            Vector2 randomPosition = new Vector2(xPosition, 6);
            transform.position = randomPosition;
        }

        else if (SpawnPoint == 1)
        {
            Vector2 randomPosition = new Vector2(xPosition, -6);
            transform.position = randomPosition;
        }

        else if (SpawnPoint == 2)
        {
            Vector2 randomPosition = new Vector2(10, yPosition);
            transform.position = randomPosition;
        }

        else if (SpawnPoint == 3)
        {
            Vector2 randomPosition = new Vector2(-10, yPosition);
            transform.position = randomPosition;
        }

        return;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Bullet"))
        {
            Destroy(gameObject);
            Points = int.Parse(points.text);
            Points += PointsToGet;
            points.text = Points.ToString();
        }

        if (collision.gameObject.tag.Contains("Player"))
        {
            Destroy(gameObject);
        }
    }

}
