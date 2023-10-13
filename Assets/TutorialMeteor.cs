using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialMeteor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.left;
        if (transform.position == new Vector3(0,0,0))
        {
            transform.position = Vector2.zero;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}
