using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour
{
    public float speed;

    TextMeshPro bulletsLeft;
    int bullet;

    // Start is called before the first frame update
    void Start()
    {
        bulletsLeft = GameObject.Find("Bullets").GetComponent<TextMeshPro>();
        
        bullet = int.Parse(bulletsLeft.text);
        bullet -= 1;
        bulletsLeft.text = bullet.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);

        if (transform.position.x > 10 || transform.position.x < -10 || transform.position.y < -10 || transform.position.y > 10)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Meteor"))
        {
            bullet = int.Parse(bulletsLeft.text);
            bullet += 1;
            bulletsLeft.text = bullet.ToString();
            Destroy(gameObject);
        }
    }
}
