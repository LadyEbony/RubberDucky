﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorEvent : MonoBehaviour {

    public float cursorSpeed;
    [SerializeField] string HorizontalAxis;
    [SerializeField] string VerticalAxis;
    [SerializeField] string AButton;
    float horizontal;
    float vertical;

    public GameObject RippleObject;
    public string playerid;

    [SerializeField]
    float x_change = 0.15f;
    [SerializeField]
    float y_change = 0.19f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        horizontal = Input.GetAxisRaw(HorizontalAxis + playerid);
        vertical = Input.GetAxisRaw(VerticalAxis + playerid);
       // Debug.Log(horizontal + " " + vertical);
        if ((horizontal != 0) | (vertical != 0))
        {
            Vector3 move = new Vector3(horizontal, -vertical, 0);
            //Debug.Log(move);
            transform.Translate(move * Time.deltaTime * cursorSpeed);
        }
        else
        {
            transform.Translate(Vector3.zero);
            //Debug.Log("Stop");
        }
        if(Input.GetButtonDown(AButton + playerid))
        {
            //Debug.Log("Pressed A");
            CreateWave();
        }
        

    }
    private void CreateWave()
    {
        float mousex = transform.position.x + x_change;
        float mousey = transform.position.y + y_change;
        //Debug.Log("x: " + mousex + "| y: " + mousey);
        GameObject wave = (GameObject)Instantiate(RippleObject);
        Transform waveb = wave.GetComponent<Transform>();
        //waveb.transform.SetParent(this.transform);
        waveb.transform.localPosition = new Vector3(mousex, mousey, 0);
        waveb.transform.localScale = new Vector3(1, 1, 1);
    }
}
