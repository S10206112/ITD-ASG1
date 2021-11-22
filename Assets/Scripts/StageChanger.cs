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
    public GameObject airSetter;
    public GameObject[] airArray;


    // Start is called before the first frame update
    void Start()
    {
        //find stage objects and create array
        stageArray = GameObject.FindGameObjectsWithTag("Stage");

        //disable all stages
        foreach (GameObject stage in stageArray)
        {
            stage.SetActive(false);
        }

        airArray = GameObject.FindGameObjectsWithTag("Air");

        foreach (GameObject air in airArray)
        {
            air.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if stages have been filled -> initiate code
        if (stageArray != null)
        {
            if(activeStage >= stageArray.Count())
            {
                airSetter.GetComponent<ContentPositioningBehaviour>().AnchorStage = airArray[activeStage - stageArray.Count()].GetComponent<AnchorBehaviour>();
                airArray[activeStage - stageArray.Count()].SetActive(true);
            }
            else
            {
                stageSetter.GetComponent<ContentPositioningBehaviour>().AnchorStage = stageArray[activeStage].GetComponent<AnchorBehaviour>();
                stageArray[activeStage].SetActive(true);
            }
        }
    }

    public void BtnClicked()
    {
        //Disable all other stages
        foreach (GameObject stage in stageArray)
        {
            stage.SetActive(false);
        }

        foreach (GameObject stage in airArray)
        {
            stage.SetActive(false);
        }

        //change value of activeStage
        if (activeStage == ((stageArray.Count() + airArray.Count() - 1)))
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