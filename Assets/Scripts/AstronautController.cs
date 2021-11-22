using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautController : MonoBehaviour
{
    public Animator myAnimator;

    public void StarWave()
    {
        //set the ismoving bool of myanim to true
        myAnimator.SetBool("IsWaving", true);
    }
}
