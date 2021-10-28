using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetTracker : MonoBehaviour
{
    private Dictionary<GameObject, bool> trackedObjectStatus = new Dictionary<GameObject, bool>();

    public Text debugText;

    public void ObjectTracked(GameObject objectToTrack)
    {
        //check if passed in object is valid
        if(objectToTrack != null)
        {
            // if its valid, update the dictionary value to true
            trackedObjectStatus[objectToTrack] = true;
            //debugText.text = objectToTrack.name + " :" + trackedObjectStatus[objectToTrack].ToString();
        }
        else
        {
            //if its not valid, dont do anything
            return;
        }
    }

    public void ObjectLost(GameObject objectToTrack)
    {
        //check if passed in object is valid
        if(objectToTrack != null)
        {
            // if its valid, update the dictionary value to true
            trackedObjectStatus[objectToTrack] = false;
            //debugText.text = objectToTrack.name + " :" + trackedObjectStatus[objectToTrack].ToString();
        }
        else
        {
            //if its not valid, dont do anything
            return;
        }
    }


    private void UpdateObjects()
    {
        //check if there are gameobjects in the dictionary
        if(trackedObjectStatus.Count > 0)
        {
            //if there are objects, update my debugtext
            debugText.text = "";

            foreach(KeyValuePair<GameObject, bool> objectStatus in trackedObjectStatus)
            {
                // look through the dictionary and update the debugtext
                debugText.text += objectStatus.Key.name + ": " + objectStatus.Value + '\n';
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        UpdateObjects();
    }
}
