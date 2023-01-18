using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{
    public Texture2D screenshot;
    public int width, height;
    public Renderer[] renderers;

    void Start()
    {
        width = Screen.width;
        height = Screen.height;
        screenshot = new Texture2D(width, height, TextureFormat.RGB24, false);
        renderers = GetComponentsInChildren<Renderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F9))
        {
            foreach (Renderer r in renderers)
            {
                r.enabled = false;
            }

            screenshot.ReadPixels(new Rect(0, 0, width, height), 0, 0);
            screenshot.Apply();
            byte[] bytes = screenshot.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.dataPath + "/screenshot.png", bytes);

            foreach (Renderer r in renderers)
            {
                r.enabled = true;
            }
        }
    }
}
