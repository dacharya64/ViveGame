﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    //private GameObject rig;
    private GameObject cam;
    // Use this for initialization
    void Start()
    {
        //rig = GetComponent<GameObject>();
        cam = GameObject.Find("Camera (eye)");

}

    // Update is called once per frame
    void Update()
    {
        //sets the center of the collider to the camera location
        this.transform.position = cam.GetComponent<Transform>().position;
        //this.GetComponent<BoxCollider>().center = cam.GetComponent<Transform>().position;
    }
}
