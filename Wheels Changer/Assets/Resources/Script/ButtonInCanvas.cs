using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonInCanvas : MonoBehaviour
{
   public void BackButton()
    {
        SceneManager.LoadScene("Menu_Brand");
    }

    public void Camera()
    {
        ScreenCapture.CaptureScreenshot("Heavenly_Effect_Visualizatiom.JPEG");
    }

}
