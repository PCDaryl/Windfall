﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Behavior : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(gameObject.GetComponent<Transform>().position.y < -10)
        {
            Destroy(gameObject);
        }
	}
}
