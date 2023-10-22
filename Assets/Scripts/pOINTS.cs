using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class pOINTS : MonoBehaviour
{
    public TextMeshPro Points;
    public TextMeshProUGUI AllPoints;

    public GameObject Everything;

    public GameObject bullet;
    BulletScript bulletSpeed;
    private void Start()
    {
        bulletSpeed = bullet.GetComponent<BulletScript>();

        bulletSpeed.speed = 5;

    }

    private void Update()
    {
        AllPoints.text = Points.text;
        Everything.SetActive(false);

        GameObject[] meteors = GameObject.FindGameObjectsWithTag("Meteor");

        foreach (GameObject meteor in meteors)
        {
            Destroy(meteor);
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("EnterScene");
    }
} 
