using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARtoggle : MonoBehaviour
{
    public void ToggleAR()
    {
        // check if camera is on
        if(VuforiaBehaviour.Instance.enabled)
        {
            // if its on, turn it off
            VuforiaBehaviour.Instance.enabled = false;
        }
        else
        {
            //if its off, turn it on
            VuforiaBehaviour.Instance.enabled = true;
        }
        

    }

}
