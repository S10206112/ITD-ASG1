/******************************************************************************
Author: Dan
Name of Class: ImageChanger
Description of Class: Toggles between the different food items in the menu page
Date Created: 24/11/2021
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Vuforia;


public class ImageChanger : MonoBehaviour
{
    public int activeImage = 0;
    public GameObject[] ImageArray;
   
    // Start is called before the first frame update
    void Start()
    {
        ImageArray = GameObject.FindGameObjectsWithTag("Image");

         //disable all stages
        foreach (GameObject image in ImageArray)
        {
            image.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //if stages have been filled -> initiate code
        if (ImageArray != null)
        {
            ImageArray[activeImage].SetActive(true);
            
        }
    }

    public void BtnClicked()
    {
        //Disable all other stages
        foreach (GameObject image in ImageArray)
        {
            image.SetActive(false);
        }


        //change value of activeStage
        if (activeImage == ((ImageArray.Count() - 1)))
        {
            activeImage = 0;
            Debug.Log("BtnClicked");
        }
        else
        {
            activeImage++;
        }
    }

   
}
