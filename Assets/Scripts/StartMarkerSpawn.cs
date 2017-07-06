﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script positions the first marker at the starting marker position. 

public class StartMarkerSpawn : MonoBehaviour {
    
    float xCoord;
    float zCoord;
    public static int degree;
    private GameObject GameController;


    // Use this for initialization
    void Start() {

        //main game controller 
        GameController = GameObject.Find("GameController");
        Restart RestartScript = GameController.GetComponent<Restart>();


        xCoord = 0;
        zCoord = 0;

        

        //depending on random roll, set start marker to start position and rotation towards origin
        if (RestartScript.startPosition == 1)
        {
            xCoord = -1.83f;
            degree = 270;

        }
        else if (RestartScript.startPosition == 2)
        {
            zCoord = 2.44f;
            degree = 0;
        }
        else if (RestartScript.startPosition == 3)
        {
            xCoord = 1.83f;
            degree = 90;
        }
        else if (RestartScript.startPosition == 4)
        {
            zCoord = -2.44f;
            degree = 180;
        }
        else if (RestartScript.startPosition == 5)
        {
            xCoord = -1.22f;
            zCoord = 1.524f;
            degree = 315;
        }
        else if (RestartScript.startPosition == 6)
        {
            xCoord = 1.22f;
            zCoord = 1.524f;
            degree = 45;
        }
        else if (RestartScript.startPosition == 7)
        {
            xCoord = 1.22f;
            zCoord = -1.524f;
            degree = 135;
        }
        else { //randnum == 8
            xCoord = -1.22f;
            zCoord = -1.524f;
            degree = 225;
        }

        this.transform.Rotate(0, degree, 0);
        this.transform.position = new Vector3(xCoord, 0, zCoord);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
