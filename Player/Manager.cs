using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;

    public static int numberOfCoins;
    void Start()
    {
        gameOver = false;
        Time.timeScale = 1;
        numberOfCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

    }
}
