using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI OrderText;

    public TextMeshProUGUI FoodDetails;

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
        OrderText.text = "Added to Order";
    }
}
