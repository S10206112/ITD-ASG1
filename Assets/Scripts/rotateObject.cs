/******************************************************************************
Author: Kirdesh
Name of Class: rotateObject
Description of Class: Animation that rotates the object around to make the app more dynamic 
Date Created: 31/10/2021
******************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around y axis
        transform.Rotate(0, Time.deltaTime * 30, 0);
    }
}
