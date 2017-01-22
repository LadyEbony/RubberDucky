using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBounds : MonoBehaviour {

    // Use this for initialization
    public float camerax;
    public float cameray;
	void Start () {
	}

    // Update is called once per frame
    void Update()
    {

        // X axis
        if (transform.position.x <= -11.3f)
        {
            transform.position = new Vector2(-camerax, transform.position.y);
        }
        else if (transform.position.x >= 11.3f)
        {
            transform.position = new Vector2(camerax, transform.position.y);
        }

        // Y axis
        if (transform.position.y <= -5f)
        {
            transform.position = new Vector2(transform.position.x, -cameray);
        }
        else if (transform.position.y >= 5f)
        {
            transform.position = new Vector2(transform.position.x, cameray);
        }
    }
}
