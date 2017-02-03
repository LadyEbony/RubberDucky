using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBounds : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer Screen;

    private Vector3 LastPosition;

    // Use this for initialization
	void Start ()
    {
        transform.position = Screen.transform.position;
	}

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.localPosition.x + " > " + Screen.transform.localPosition.x + " + " + Screen.sprite.rect.size.x);
        if (transform.localPosition.x > Screen.transform.localPosition.x + Screen.sprite.rect.size.x)
            //transform.localPosition.x < Screen.transform.localPosition.x + Screen.sprite.bounds.min.x ||
          // transform.localPosition.y > Screen.transform.localPosition.y + Screen.sprite.bounds.max.y ||
           // transform.localPosition.y < Screen.transform.localPosition.y + Screen.sprite.bounds.min.y)
        {
            //transform.position = Mathf.Clamp();
        }
       else
        {
            Debug.Log("ignore");
            LastPosition = transform.position;
        }
       
    }
}
