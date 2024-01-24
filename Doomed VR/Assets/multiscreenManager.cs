using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiscreenManager : MonoBehaviour
{
    void Start()
    {
        if (Display.displays.Length > 1)
        {
            Display.displays[1].Activate(Display.displays[1].renderingWidth, Display.displays[1].renderingHeight, Screen.currentResolution.refreshRateRatio);
        }
        else
        {
            Debug.Log("No second display found.");
        }
    }
}
