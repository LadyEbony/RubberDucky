using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleMenuButtons : MonoBehaviour {

    public void StartButton()
    {
        Debug.Log("Start pressed");
        GameObject.Find("Controller1").GetComponent<TitleMenuControllers>().GoToCenter();
        GameObject.Find("Controller2").GetComponent<TitleMenuControllers>().GoToCenter();
    }

    public void QuitButton()
    {
        Debug.Log("Quit pressed");
        Application.Quit();
    }

}
