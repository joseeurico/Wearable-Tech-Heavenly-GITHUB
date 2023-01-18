using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UITEST : MonoBehaviour

{
    public void CHRbutton()
    {
        SceneManager.LoadScene("CHR");
    }

    public void NT10button()
    {
        SceneManager.LoadScene("NT10");
    }

    public void Emotionbutton()
    {
        SceneManager.LoadScene("Emotion");
    }

    public void Integralebutton()
    {
        SceneManager.LoadScene("Integrale");
    }

    public void ROCbutton()
    {
        SceneManager.LoadScene("ROC");
    }
}


