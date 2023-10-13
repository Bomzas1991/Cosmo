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

    public AudioClip LaserBullet;
    //public Animation Hit;
    public GameObject BulletHit;
    public float bounce = 20f;
    public AudioClip Death;

    // Start is called before the first frame update
    void Start()
    {
        bulletsLeft = GameObject.Find("Bullets").GetComponent<TextMeshPro>();
        
        bullet = int.Parse(bulletsLeft.text);
        bullet -= 1;
        bulletsLeft.text = bullet.ToString();

        //Hit = gameObject.GetComponent<Animation>();

        AudioSource.PlayClipAtPoint(LaserBullet, transform.position, 1);
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
            //Hit.Play("BlueBulletHit");

            AudioSource.PlayClipAtPoint(Death, transform.position, 2);
            Instantiate(BulletHit, transform.position, transform.rotation);


            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
        }
            Destroy(gameObject);
    }
}
