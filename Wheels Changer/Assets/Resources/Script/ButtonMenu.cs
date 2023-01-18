using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonMenu : MonoBehaviour
{
    public void StartMenu()
    {
        SceneManager.LoadScene("Menu_Brand");
    }

    public void Help()
    {
        SceneManager.LoadScene("Menu_Help");
    }

    public void Contact()
    {
        Application.OpenURL("https://www.instagram.com/heavenly_ltd/");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
