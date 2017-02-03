using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleMenuControllers : MonoBehaviour {

    [SerializeField]
    private GameObject Controller1Image;
    [SerializeField]
    private GameObject Controller2Image;

    // Use this for initialization
    void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Start_P1"))
        {
            Controller1Image.GetComponent<Outline>().enabled = true;
        }
        if (Input.GetButtonDown("Start_P2"))
        {
            Controller2Image.GetComponent<Outline>().enabled = true;
        }

        if (Input.GetButtonUp("Start_P1"))
        {
            Controller1Image.GetComponent<Outline>().enabled = false;
        }
        if (Input.GetButtonUp("Start_P2"))
        {
            Controller2Image.GetComponent<Outline>().enabled = false;
        }

        if (Input.GetButton("Start_P1") && Input.GetButton("Start_P2"))
        {
            SceneManager.LoadScene("Stage0");
        }

		if (Input.GetButtonDown ("Cancel_Base"))
        {
            SceneManager.LoadScene("TitleMenu");
        }
    }
}
