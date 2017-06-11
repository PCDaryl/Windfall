using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Behavior : MonoBehaviour
{
    private bool outOfBounds = false;

	void Update ()
    {
        if(outOfBounds)
        {
           // gameObject.GetComponent<Transform>().position.y = 0.0f;
            outOfBounds = true;
        }
		
	}

    private void FixedUpdate()
    {
        if(gameObject.GetComponent<Transform>().position.y < -6)
        {
            outOfBounds = true;
        }
    }
}
