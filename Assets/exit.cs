﻿using UnityEngine;
using System.Collections;

public class exit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Application.Quit();
        Debug.Log("Exit");
    }


}
