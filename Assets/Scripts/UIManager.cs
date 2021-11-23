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
        OrderText.text = "Added to Order";
    }

    public void ToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ToFoodMenu()
    {
        SceneManager.LoadScene("FoodMenu");
    }
}
