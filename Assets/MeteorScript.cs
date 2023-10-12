using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using TMPro;

public class MeteorScript : MonoBehaviour
{
    public float speed;
    float timer;

    public Text points;
    int Points;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPointQ();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Vector2.zero, speed * Time.deltaTime);

        timer += Time.deltaTime;

        if (timer >= 10)
        {
            speed += 10;
            timer = 0;
        }
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
            Points++;
            points.text = Points.ToString();
        }

        if (collision.gameObject.tag.Contains("Player"))
        {
            Destroy(gameObject);
        }
    }
}
