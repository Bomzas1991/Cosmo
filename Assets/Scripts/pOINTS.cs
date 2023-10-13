using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class pOINTS : MonoBehaviour
{
    public TextMeshPro Points;
    public TextMeshProUGUI AllPoints;

    private void Update()
    {
        AllPoints.text = Points.text;
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
