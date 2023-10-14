using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePoint;

    TextMeshPro bullets;
    public TextMeshPro points;
    public GameObject PowerUps;

    public AudioClip Death;

    public GameObject Explosion;
    public GameObject End;

    public GameObject Heart;
    TextMeshPro liVes;
    int lives;

    // Start is called before the first frame update
    void Start()
    {
        //Cursor.visible = false;
        bullets = GameObject.Find("Bullets").GetComponent<TextMeshPro>();
        liVes = GameObject.Find("lives").GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.up = direction;

        lives = int.Parse(liVes.text);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Shoot();
        }

        if (int.Parse(bullets.text) < 0)
        {
            Destroy(gameObject);
            End.SetActive(true);
        }

        if (lives < 1)
        {
            AudioSource.PlayClipAtPoint(Death, transform.position, 5);
            Instantiate(Explosion, transform.position, transform.rotation);

            Destroy(gameObject);

            End.SetActive(true);
        }

        int point = int.Parse(points.text);

        //doublePoints = GameObject.FindWithTag("Meteor").GetComponent<MeteorScript>();
        if (point == 2)
        {
            PowerUps.SetActive(true);
            point = 0;
        }
    }

    void Shoot()
    {
        Instantiate(bullet, firePoint.position, transform.rotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Meteor"))
        {
            lives -= 1;

            liVes.text = lives.ToString();
        }
    }
}
