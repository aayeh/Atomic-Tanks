using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void GotoMainScene()
    {
        SceneManager.LoadScene("main");
    }

    public void GotoMenuScene()
    {
        SceneManager.LoadScene("TitleScreen");
    }
}
