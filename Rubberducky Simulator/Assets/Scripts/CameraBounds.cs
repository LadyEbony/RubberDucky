using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBounds : MonoBehaviour {

    // Use this for initialization
    public float camerax;
    public float cameray;
    public float cameranegx; //Must be negative
    public float cameranegy; //These must be negative
	void Start () {
	}

    // Update is called once per frame
    void Update()
    {

        // X axis
        if (transform.position.x <= cameranegx)
        {
            transform.position = new Vector2(cameranegx, transform.position.y);
        }
        else if (transform.position.x >= camerax)
        {
            transform.position = new Vector2(camerax, transform.position.y);
        }

        // Y axis
        if (transform.position.y <= cameranegy)
        {
            transform.position = new Vector2(transform.position.x, cameranegy);
        }
        else if (transform.position.y >= cameray)
        {
            transform.position = new Vector2(transform.position.x, cameray);
        }
    }
}
