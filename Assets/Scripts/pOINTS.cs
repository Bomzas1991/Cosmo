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
    private void Update()
    {
        AllPoints.text = Points.text;
        Everything.SetActive(false);

        bulletSpeed = bullet.GetComponent<BulletScript>();

        bulletSpeed.speed = 5;
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
