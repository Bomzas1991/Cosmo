using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawnerScript : MonoBehaviour
{
    float timer;
    int time = 3;
    float timeSpawn;
    int meteorCount = 1;

    public GameObject meteor1;
    public GameObject meteor2;
    public GameObject meteor3;
    public GameObject meteorBounce;
    public BulletScript bulletScriopt;

    private void Start()
    {
        bulletScriopt = bulletScriopt.GetComponent<BulletScript>();

        bulletScriopt.speed = 5;
    }

    void Update()
    {
        timer += Time.deltaTime;
        timeSpawn += Time.deltaTime;

        if (timer >= time)
        {
            if (meteorCount == 1)
            {
                Spawn();
                timer = 0;
            }

            else if (meteorCount == 2)
            {
                Spawn2();
                timer = 0;
            }

            else if (meteorCount >= 3)
            {
                Spawn3();
                timer = 0;

                if (timeSpawn >= 5)
                {
                    Spawn4();
                    timeSpawn = 0;
                }
            }
        }

        if (timeSpawn >= 20)
        {
            meteorCount++;

            timeSpawn = 0;
            if (time > 1)
            {
                time -= 1;
            }
            else
            {
                time = 1;
            }
        }

        timer += Time.deltaTime;

        if (timer >= 10)
        {
            MeteorScript speed = GetComponent<MeteorScript>();
            speed.speed += 10;
            timer = 0;
        }
    }

    void Spawn()
    {
       Instantiate(meteor1, transform.position, transform.rotation);
    }
    void Spawn2()
    {
        Instantiate(meteor2, transform.position, transform.rotation);
    }
    void Spawn3()
    {
        Instantiate(meteor3, transform.position, transform.rotation);
    }
    void Spawn4()
    {
        Instantiate(meteorBounce, transform.position, transform.rotation);
    }
}
