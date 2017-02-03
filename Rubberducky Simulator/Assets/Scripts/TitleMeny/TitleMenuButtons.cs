using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleMenuButtons : MonoBehaviour {

	[SerializeField] public GameObject DuckCursor;

    private void Start()
    {

    }
    
    public void GoToScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
