using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleMenuButtons : MonoBehaviour {

    [SerializeField] private GameObject ButtonSelected;
    [SerializeField] private GameObject ButtonNotSelected;

    [SerializeField] private GameObject ButtonStart;
    [SerializeField] private GameObject ButtonQuit;

    [SerializeField] private int MaxWidth = 600;
    [SerializeField] private int MaxHeight = 200;
    [SerializeField] private int MinWidth = 450;
    [SerializeField] private int MinHeight = 150;

    [SerializeField] private float growthWidthSpeed = 30;
    [SerializeField] private float growthHeightSpeed = 10;

    [SerializeField] private bool Interavtive;

    private void Start()
    {
        ButtonStart = GameObject.Find("Start");
        ButtonQuit = GameObject.Find("Quit");

        ButtonSelected = ButtonStart;
        ButtonNotSelected = ButtonQuit;

        Interavtive = true;
    }

    private void Update()
    {
        if (Interavtive)
        {
            if (Input.GetAxis("Joystick_Base") < -0.5)
            {
                ButtonSelected = ButtonStart;
                ButtonNotSelected = ButtonQuit;
            }
            else if (Input.GetAxis("Joystick_Base") > 0.5)
            {
                ButtonSelected = ButtonQuit;
                ButtonNotSelected = ButtonStart;
            }

            UpdateSize();

            DetectButton();
        }
    }

    private void StartButton()
    {
        Debug.Log("Start pressed");
        GameObject.Find("Controller1").GetComponent<TitleMenuControllers>().GoToCenter();
        GameObject.Find("Controller2").GetComponent<TitleMenuControllers>().GoToCenter();
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
            if (ButtonSelected = ButtonStart)
            {
                StartButton();
            }
            else if (ButtonSelected = ButtonQuit)
            {
                QuitButton();
            }
        }
    }

}
