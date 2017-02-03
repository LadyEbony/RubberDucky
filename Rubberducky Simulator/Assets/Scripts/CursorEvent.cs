using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorEvent : MonoBehaviour {

    public float cursorSpeed;
    float horizontal;
    float vertical;

    public GameObject RippleObject;
    public string playerid;

    [SerializeField]
    float x_change = 0.15f;
    [SerializeField]
    float y_change = 0.19f;

    private GameObject DuckConvo;

    // Use this for initialization
    void Awake ()
    {
        DuckConvo = GameObject.FindGameObjectWithTag("DuckConversation");
        
	}
	
    void Start()
    {
        transform.position = transform.parent.transform.position;
    }

    void Update()
    {
        if (DuckConvo != null && DuckConvo.activeInHierarchy)
            return;

        if (Input.GetButtonDown("Submit_P" + playerid))
        {
            //Debug.Log("Pressed A");
            CreateWave();
        }
    }

	// Update is called once per frame
	void FixedUpdate ()
    {
        if (DuckConvo != null && DuckConvo.activeInHierarchy)
            return;

        horizontal = Input.GetAxisRaw("Horizontal_P" + playerid);
        vertical = Input.GetAxisRaw("Vertical_P" + playerid);
       // Debug.Log(horizontal + " " + vertical);
        if ((horizontal != 0) | (vertical != 0))
        {
            Vector3 move = new Vector3(horizontal, -vertical, 0);
            //Debug.Log(move);
            GetComponent<Rigidbody2D>().MovePosition(transform.position + move * Time.fixedDeltaTime * cursorSpeed);
            //transform.Translate(move * Time.deltaTime * cursorSpeed); 
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
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
