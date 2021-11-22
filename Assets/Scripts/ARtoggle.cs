using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ARtoggle : MonoBehaviour
{
    public GameObject Object1;
    public GameObject Object2;
    public GameObject Object3;
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
