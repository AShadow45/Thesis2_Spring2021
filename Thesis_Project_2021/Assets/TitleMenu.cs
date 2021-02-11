using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    void PlayButton()
    {
        SceneManager.LoadScene("Test Arena");
    }

    void QuitButton()
    {
        Application.Quit();
    }
}
