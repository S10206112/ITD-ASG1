using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TouchTracker : MonoBehaviour
{
    private Touch firstTouch;

    public Text debugText;


    public TextMeshProUGUI foodDetails;

    // Update is called once per frame
    void Update()
    {
        StoreTouches();
    }

    public void StoreTouches()
    {
        //if using laptop
        if(Input.GetMouseButton(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit info;
            
            if (Physics.Raycast(ray, out info))
            {
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
                     }
                     if(info.collider.name == "Hotdog")
                     {
                        foodDetails.text = "This is the finest Hotdog Bun, wrapped with extra steamy buns";
                     }
                     if(info.collider.name == "Watermelon")
                     {
                        foodDetails.text = "This is the juicy watermelon from the Beijing Corn Company";
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

                // when user isn't clicking on any food items
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
                        foodDetails.text = "This is a Burger obviously and it comes at a price etc etc";
                     }
                     //if(info.collider.name == "Food")
                     //{
                     //   foodDetails.text = "This is a Lorem Ipsum and it comes at a price etc etc";
                     //}
                     //if(info.collider.name == "Food")
                     //{
                     //   foodDetails.text = "This is a Lorem Ipsum and it comes at a price etc etc";
                     //}
                     //if(info.collider.name == "Food")
                     //{
                     //   foodDetails.text = "This is a Lorem Ipsum and it comes at a price etc etc";
                     //}

                 };
            }
            else
            {
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
