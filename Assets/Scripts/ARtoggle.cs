using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;

public class ARtoggle : MonoBehaviour
{
    public void ToggleAR()
    {
        // check if camera is on
        if(VuforiaBehaviour.Instance.enabled)
        {
            // if its on, turn it off
            VuforiaBehaviour.Instance.enabled = false;

            //do something here that basically turns off the current UI and shows a decent background
            SceneManager.LoadScene("BlankScreen");
        }
        else
        {
            //if its off, turn it on
            VuforiaBehaviour.Instance.enabled = true;

            //do something here that basically turns on the menu UI and turns off the decent background
        }
        

    }

}
