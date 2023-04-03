using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtons : MonoBehaviour
{
    public void OnScenePressed()
    {
        SceneManager.LoadScene(this.name);
    }

    public void OnQuitPressed()
    {
        Application.Quit();
    }
}
