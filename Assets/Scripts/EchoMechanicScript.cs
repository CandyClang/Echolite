﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoMechanicScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Debug.Log("Spawn Echo");

            //Spawn echo particles
        }
    }
}
