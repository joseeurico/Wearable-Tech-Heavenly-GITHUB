using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonSample : MonoBehaviour
{
    public VirtualButtonBehaviour vbn;


    public void Start()
    {
        vbn.RegisterOnButtonPressed(OnButtonPressed0);
        vbn.RegisterOnButtonReleased(OnButtonReleased0);
        Debug.Log("start");
        
    }
    public void OnButtonPressed0(VirtualButtonBehaviour vb)
    {

      Debug.Log("pencet0");

    }

    public void OnButtonReleased0(VirtualButtonBehaviour vb)
    {
        Debug.Log("lepas0");
    }
}
