﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fridge : MonoBehaviour {
    private Animator animator;
    private bool isInside;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isInside = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FridgeSlideRight()
    {
        if (isInside)
        {
            //FridgeSlideLeft
            animator.Play("FridgeSlideLeft");
        }
        else
        {
            animator.Play("FridgeSlideRight");
        }
        isInside = !isInside;
    }

    public void FridgeSlideUp()
    {
        if (isInside)
        {
            //FridgeSlideLeft
            animator.Play("FridgeSlideDown");
        }
        else
        {
            animator.Play("FridgeSlideUp");
        }
        isInside = !isInside;
    }
}
