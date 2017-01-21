using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckyEvent : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("COLLISON");
    }
}
