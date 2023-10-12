using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySettingQuit : MonoBehaviour
{
    public void Play()
    {
         SceneManager.LoadScene("SampleScene");
    }

    public void Settings()
    {
        
    }

    public void Quit()
    {
        Application.Quit();
    }
}
