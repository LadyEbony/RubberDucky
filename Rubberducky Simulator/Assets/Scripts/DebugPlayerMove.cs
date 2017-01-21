using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugPlayerMove : MonoBehaviour
{
    [SerializeField]
    private float Speed = 2f;

    private Rigidbody2D RB;

	// Use this for initialization
	void Awake ()
    {
        RB = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
	    if (Input.GetKey("w"))
        {
            RB.AddForce(Vector2.up * Speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey("a"))
        {
            RB.AddForce(Vector2.left * Speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey("d"))
        {
            RB.AddForce(Vector2.right * Speed * Time.fixedDeltaTime);
        }
        if (Input.GetKey("s"))
        {
            RB.AddForce(Vector2.down * Speed * Time.fixedDeltaTime);
        }
    }
}
