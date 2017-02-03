using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    void Update()
    {
        if (Input.GetButtonDown("Cancel_Base"))
        {
            SceneManager.LoadScene("TitleMenu");
        }
    }
}
