/******************************************************************************
Author: Dan & Kirdesh
Name of Class: TouchTracker
Description of Class: Obtains the info on what object is being interacted with as well as the actions that would take place
Date Created: 24/11/2021
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TouchTracker : MonoBehaviour
{
    private Touch firstTouch;

    public Text debugText;
    
    public Image BurgerInfo;
    public Image HotdogInfo;
    public Image WatermelonInfo;


    public TextMeshProUGUI foodDetails;

    // Update is called once per frame
    void Update()
    {
        StoreTouches();
    }

    void Start()
    {
        //turns off all the food info when the scene is opened up
        BurgerInfo.gameObject.SetActive(false);
        HotdogInfo.gameObject.SetActive(false);
        WatermelonInfo.gameObject.SetActive(false);
    }

    //store the data of the touches made by the user
    public void StoreTouches()
    {
        //if using laptop
        if(Input.GetMouseButton(0))
        {
            //do a raycast based on where the mouse clicks on the screen
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit info;
            
            //if the raycast does hit something it stores that info for future usage
            if (Physics.Raycast(ray, out info))
            {
                //debugtext stuff
                debugText.text = "first touch is at: " + Input.mousePosition + "hit an object: " + info.collider.name 
                + "with tag " + info.collider.tag;

                //when a food item with that tag is clicked
                if(info.collider.tag == "FoodItem")
                 {
                     //Do a code that calls a food details function
                     Debug.Log("Print food details");
                     

                     //changes the text based on which food item was clicked
                     if(info.collider.name == "Hamburger")
                     {
                        foodDetails.text = "This is a Burger slapped in with a piece of juicy meat inside it";
                        //activate the text information for the burger
                        BurgerInfo.gameObject.SetActive(true);
                     }
                     if(info.collider.name == "Hotdog")
                     {
                        foodDetails.text = "This is the finest Hotdog Bun, wrapped with extra steamy buns";
                        //activate the text information for the hotdog
                        HotdogInfo.gameObject.SetActive(true);
                     }
                     if(info.collider.name == "Watermelon")
                     {
                        foodDetails.text = "This is the juicy watermelon from the Beijing Corn Company";
                        //activate the text information for the watermelon
                        WatermelonInfo.gameObject.SetActive(true);
                     }
                     
                     //Template for the food info
                     //if(info.collider.name == "Food")
                     //{
                     //   foodDetails.text = "This is a Lorem Ipsum and it comes at a price etc etc";
                     //}

                 };
            }
            else
            {
                // set all the info description of the food to false
                BurgerInfo.gameObject.SetActive(false);
                HotdogInfo.gameObject.SetActive(false);
                WatermelonInfo.gameObject.SetActive(false);


                // when user is clicking outside any food items
                foodDetails.text = "Click on the Food!";
                return;
            }
           
        }
        
        

        //check if there are any touches
        if(Input.touchCount > 0)
        {
            //store touch in firsttouch
            firstTouch = Input.GetTouch(0);

            Ray ray = Camera.main.ScreenPointToRay(firstTouch.position);
            RaycastHit info;

            if(Physics.Raycast(ray, out info))
            {
                //display information about the firsttouch
                debugText.text = "first touch is at: " + firstTouch.position + "." +
                "and hit object " + info.collider.name + "with tag " + info.collider.tag;

                //when a food item with that tag is clicked
                if(info.collider.tag == "FoodItem")
                 {
                     //Do a code that calls a food details function
                     Debug.Log("Print food details");
                     

                     //changes the text based on which food item was clicked
                     if(info.collider.name == "Hamburger")
                     {
                        foodDetails.text = "This is a Burger slapped in with a piece of juicy meat inside it";
                        //activate the text information for the burger
                        BurgerInfo.gameObject.SetActive(true);
                     }
                     if(info.collider.name == "Hotdog")
                     {
                        foodDetails.text = "This is the finest Hotdog Bun, wrapped with extra steamy buns";
                        //activate the text information for the hotdog
                        HotdogInfo.gameObject.SetActive(true);
                     }
                     if(info.collider.name == "Watermelon")
                     {
                        foodDetails.text = "This is the juicy watermelon from the Beijing Corn Company";
                        //activate the text information for the watermelon
                        WatermelonInfo.gameObject.SetActive(true);
                     }
                     
                     //Template for the food info
                     //if(info.collider.name == "Food")
                     //{
                     //   foodDetails.text = "This is a Lorem Ipsum and it comes at a price etc etc";
                     //}

                 };
            }
            else
            {
                // set all the info description of the food to false
                BurgerInfo.gameObject.SetActive(false);
                HotdogInfo.gameObject.SetActive(false);
                WatermelonInfo.gameObject.SetActive(false);


                // when user is clicking outside any food items
                foodDetails.text = "Click on the Food!";
                //else there are no touches, dont do anything
                return;
            }

            
        }
        else
        {
            //else there are no touches, dont do anything
            return;
        }
    }
    
}
