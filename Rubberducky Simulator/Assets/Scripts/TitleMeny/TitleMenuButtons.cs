using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleMenuButtons : MonoBehaviour {

	[SerializeField] public GameObject DuckCursor;

    [SerializeField] private GameObject ButtonSelected;
    [SerializeField] private GameObject ButtonNotSelected;

    [SerializeField] private GameObject ButtonStart;
    [SerializeField] private GameObject ButtonQuit;

    [SerializeField] private int MaxWidth = 600;
    [SerializeField] private int MaxHeight = 483;
    [SerializeField] private int MinWidth = 500;
    [SerializeField] private int MinHeight = 450;

    [SerializeField] private float growthWidthSpeed = 30;
    [SerializeField] private float growthHeightSpeed = 10;

    public bool Interavtive;

    private void Start()
    {
        ButtonStart = GameObject.Find("Start");
        ButtonQuit = GameObject.Find("Quit");

        ButtonSelected = ButtonStart;
        ButtonNotSelected = ButtonQuit;
		DuckCursor.transform.position = new Vector3(ButtonStart.transform.position.x + 2.5f,  ButtonStart.transform.position.y + 6, -0);
        Interavtive = true;
    }

    private void Update()
    {
        if (Interavtive)
        {
            if (Input.GetAxis("Joystick_Base") < -0.5)
            {
				DuckCursor.transform.position = new Vector3(ButtonStart.transform.position.x + 2.5f,  ButtonStart.transform.position.y + 6, -0);
                ButtonSelected = ButtonStart;
                ButtonNotSelected = ButtonQuit;
            }
            else if (Input.GetAxis("Joystick_Base") > 0.5)
            {
				DuckCursor.transform.position = new Vector3(ButtonQuit.transform.position.x + 2.5f,  ButtonQuit.transform.position.y + 6, -0);
                ButtonSelected = ButtonQuit;
                ButtonNotSelected = ButtonStart;
            }

			//Debug.Log ("Button Selected : " + ButtonSelected);
			//Debug.Log ("Button Not Selected : " + ButtonNotSelected);

            //UpdateSize();

            DetectButton();
        }
    }

    private void StartButton()
    {
        Debug.Log("Start pressed");
        GameObject.Find("Controller").GetComponent<TitleMenuControllers>().GoToCenter();
        Interavtive = false;
    }

    private void QuitButton()
    {
        Debug.Log("Quit pressed");
        Application.Quit();
    }

    private void UpdateSize()
    {
        if (ButtonSelected.GetComponent<RectTransform>().rect.width < MaxWidth)
        {
            ButtonSelected.GetComponent<RectTransform>().sizeDelta = 
                new Vector2(ButtonSelected.GetComponent<RectTransform>().rect.width + (growthWidthSpeed * Time.deltaTime), ButtonSelected.GetComponent<RectTransform>().rect.height);
        }
        if (ButtonSelected.GetComponent<RectTransform>().rect.height < MaxHeight)
        {
            ButtonSelected.GetComponent<RectTransform>().sizeDelta =
                new Vector2(ButtonSelected.GetComponent<RectTransform>().rect.width, ButtonSelected.GetComponent<RectTransform>().rect.height + (growthHeightSpeed * Time.deltaTime));
        }

        if (ButtonNotSelected.GetComponent<RectTransform>().rect.width > MinWidth)
        {
            ButtonNotSelected.GetComponent<RectTransform>().sizeDelta =
                new Vector2(ButtonNotSelected.GetComponent<RectTransform>().rect.width - (growthWidthSpeed * Time.deltaTime), ButtonNotSelected.GetComponent<RectTransform>().rect.height);
        }
        if (ButtonNotSelected.GetComponent<RectTransform>().rect.height > MinHeight)
        {
            ButtonNotSelected.GetComponent<RectTransform>().sizeDelta =
                new Vector2(ButtonNotSelected.GetComponent<RectTransform>().rect.width, ButtonNotSelected.GetComponent<RectTransform>().rect.height - (growthHeightSpeed * Time.deltaTime));
        }
    }

    private void DetectButton()
    {
        if (Input.GetButtonDown("Submit_Base"))
        {
            if (ButtonSelected == ButtonStart)
            {
				DuckCursor.SetActive (false);
                StartButton();
            }
            else if (ButtonSelected == ButtonQuit)
            {
                QuitButton();
            }
        }
    }

}
