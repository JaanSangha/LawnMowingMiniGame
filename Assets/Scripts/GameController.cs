using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField]
    TMP_Text grassCountText;
    [SerializeField]
    GameObject endScreen;

    private void Start()
    {
        Time.timeScale = 1;
    }
    public void SetGrassCountText(int grassCount)
    {
        //grassCountText.text = "Grass Left: " + grassCount;
    }
    public void EndGame()
    {
        Time.timeScale = 0;
        endScreen.SetActive(true);
    }
}
