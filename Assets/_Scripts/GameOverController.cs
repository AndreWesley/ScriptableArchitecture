using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    [SerializeField] private GameObject GameOverBG;
    [SerializeField] private GameObject GameOverText;

    private void Awake()
    {
        GameOverBG.SetActive(false);
        GameOverText.SetActive(false);
    }

    public void GameOver()
    {
        GameOverBG.SetActive(true);
        GameOverText.SetActive(true);
    }
}
