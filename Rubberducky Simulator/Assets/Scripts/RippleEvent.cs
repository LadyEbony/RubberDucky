using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RippleEvent : MonoBehaviour {

    public int internalCounter;
    int interalDuration;

	// Use this for initialization
	void Start () {
        internalCounter = 0;
        interalDuration = 30;
	}
	
	// Update is called once per frame
	void Update () {
        CountDown();
	}

    private void CountDown()
    {
        internalCounter++;

        if (internalCounter >= interalDuration)
        {
            Destroy(gameObject);
        }
    }

}
