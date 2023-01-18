using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrandMenu : MonoBehaviour
{
    public void SpoonMenu()
    {
        SceneManager.LoadScene("BrandSpoon");
    }

    public void BBSMenu()
    {
        SceneManager.LoadScene("BrandBBS");
    }

    public void EnkeiMenu()
    {
        SceneManager.LoadScene("BrandEnkei");
    }

    public void MugenMenu()
    {
        SceneManager.LoadScene("BrandMugen");
    }
    public void VossenMenu()
    {
        SceneManager.LoadScene("BrandVossen");
    }

    public void RotiformMenu()
    {
        SceneManager.LoadScene("BrandRotiform");
    }
    public void HSRMenu()
    {
        SceneManager.LoadScene("BrandHSR");
    }
    public void WorkMenu()
    {
        SceneManager.LoadScene("NewBrandWork");
    }

    public void VolkMenu()
    {
        SceneManager.LoadScene("BrandVolk");
    }
    public void FifteenMenu()
    {
        SceneManager.LoadScene("BrandFifteen");
    }

    public void BackFront()
    {
        SceneManager.LoadScene("UI Menu");
    }
}
