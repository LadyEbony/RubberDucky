using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour
{
    [SerializeField]
    private GameObject Door;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        GetComponent<SpriteStorage>().SetSprite(1);
        Door.GetComponent<Collider2D>().enabled = false;
        Door.GetComponent<SpriteStorage>().SetSprite(1);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        GetComponent<SpriteStorage>().SetSprite(0);
        Door.GetComponent<Collider2D>().enabled = true;
        Door.GetComponent<SpriteStorage>().SetSprite(0);
    }
}
