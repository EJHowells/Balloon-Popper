using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    //How much the balloon grows
    public float ScaleFactor = 1.2f;

    //Max balloon size
    public float MaxScale = 3;

    //start the game
    void Start()
    {
        if(ScaleFactor <= 1)
        {
            print("the scalefactor is too small!");
        }
    }
    
    //detect mouse click
    void OnMouseDown()
    {
        //access scale and increase
        transform.localScale *= ScaleFactor;

        //check if we've passed the MaxScale
        if(transform.localScale.x >= MaxScale)
        {
            //if yes, destroy balloon
            Destroy(gameObject);
        }
    }
}
