/******************************************************************************
Author: Kirdesh
Name of Class: UI Manager
Description of Class: Controls the navigation between the different scenes and the "add to order" function
Date Created: 31/10/2021
******************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI OrderText;


    public GameObject Tracker;

    private string foodname;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddtoOrder()
    {
        //when button is clicked add to order text appears
        // only representative to acknowledge that the user has clicked add to order, but does not add to any backend database
        OrderText.text = "Added to Order";
    }

    public void ToGameScene()
    {
        //loads the food box scene
        SceneManager.LoadScene("GameScene");
    }

    public void ToFoodMenu()
    {
        //loads the food menu scene
        SceneManager.LoadScene("FoodMenu");
    }

    public void ToMainMenu()
    {
        //loads the main menu scene
        SceneManager.LoadScene("MainMenu");
    }
}
