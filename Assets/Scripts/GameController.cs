using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField]
    GameObject endScreen;

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        endScreen.SetActive(true);
    }
}
