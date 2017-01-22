using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleMenuControllers : MonoBehaviour {

    private float outOfBoundsPos;
    private float InPos;
    private float moveSpeed;

    private bool CenterPosition;

    [SerializeField]
    private GameObject Controller1Image;
    [SerializeField]
    private GameObject Controller2Image;

    // Use this for initialization
    void Start () {

        outOfBoundsPos = 1260.0f * Mathf.Sign(transform.position.x);
        InPos = 660.0f * Mathf.Sign(transform.position.x);

        moveSpeed = 0.0f;
        CenterPosition = false;

        Controller1Image = GameObject.Find("ControllerImage1");
        Controller2Image = GameObject.Find("ControllerImage2");
    }
	
	// Update is called once per frame
	void Update () {
        UpdatePosition();

        if (CenterPosition)
        {
            if (Input.GetButtonDown("Submit_Base"))
            {
                Controller1Image.GetComponent<Outline>().enabled = true;
            }
            if (Input.GetButtonDown("Submit_P2"))
            {
                Controller2Image.GetComponent<Outline>().enabled = true;
            }

            if (Input.GetButtonUp("Submit_Base"))
            {
                Controller1Image.GetComponent<Outline>().enabled = false;
            }
            if (Input.GetButtonUp("Start_P2"))
            {
                Controller2Image.GetComponent<Outline>().enabled = false;
            }

            if (Input.GetButton("Submit_Base") || Input.GetButton("Submit_P2"))
            {
                GoToGame();
            }
        }

    }

    public void GoToCenter()
    {
        Debug.Log("Recieved center message.");
        moveSpeed = -10.0f * Mathf.Sign(transform.position.x);
        CenterPosition = true;

        GameObject.Find("Start").GetComponent<Button>().interactable = false;
        GameObject.Find("Quit").GetComponent<Button>().interactable = false;
    }

    public void GoOutOfBounds()
    {
        Debug.Log("Recieved outside message.");
        moveSpeed = 10.0f * Mathf.Sign(transform.position.x);
        CenterPosition = false;

        GameObject.Find("Start").GetComponent<Button>().interactable = true;
        GameObject.Find("Quit").GetComponent<Button>().interactable = true;
    }

    private void UpdatePosition()
    {
        if (InPos < 0)
        {
            if (moveSpeed != 0)
            {
                transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
                if (CenterPosition && (GetComponent<RectTransform>().anchoredPosition.x >= InPos))
                {
                    moveSpeed = 0.0f;
                }
                else if (!CenterPosition && transform.position.x <= outOfBoundsPos)
                {
                    moveSpeed = 0.0f;
                }
            }

        }
        else
        {
            if (moveSpeed != 0)
            {
                transform.Translate(new Vector3(moveSpeed * Time.deltaTime, 0, 0));
                if (CenterPosition && (GetComponent<RectTransform>().anchoredPosition.x <= InPos))
                {
                    moveSpeed = 0.0f;
                }
                else if (!CenterPosition && transform.position.x >= outOfBoundsPos)
                {
                    moveSpeed = 0.0f;
                }
            }
        }
    }

    private void GoToGame()
    {
        SceneManager.LoadScene("Stage0");
    }
}
