using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Vuforia;

public class StageChanger : MonoBehaviour
{
    public int activeStage = 0;
    public GameObject[] stageArray;
    public GameObject stageSetter;

    // Start is called before the first frame update
    void Start()
    {
        //find the stage objects and create an array
        stageArray = GameObject.FindGameObjectsWithTag("Stage");

        //disable all stages
        foreach (GameObject stage in stageArray)
        {
            stage.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if stages have been filled -> activate the code
        if(stageArray != null)
        {
            stageSetter.GetComponent<ContentPositioningBehaviour>().AnchorStage = stageArray[activeStage].GetComponent<AnchorBehaviour>();
            stageArray[activeStage].SetActive(true);
        }
    }

    public void BtnClicked()
    {
        //Disable all other stages
        foreach (GameObject stage in stageArray)
        {
            stage.SetActive(false);
        }

        //change value of activeStage
        if (activeStage == (stageArray.Count() - 1))
        {
            activeStage = 0;
            Debug.Log("BtnClicked");
        }
        else
        {
            activeStage++;
        }
    }

    
}
