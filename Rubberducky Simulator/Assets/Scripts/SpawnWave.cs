using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWave : MonoBehaviour {

    public GameObject RippleObject;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        float mousex = Input.mousePosition.x;
        float mousey = Input.mousePosition.y;
        Debug.Log("x: " + mousex + "| y: " + mousey);
    }
}
