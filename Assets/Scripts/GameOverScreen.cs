using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameOverScreen : MonoBehaviour
{
    public Text overText;
    [SerializeField] private TextMeshProUGUI scoreText;
    private GameManager game;
    public void Setup()
    {
        int score = game.getScore(); 
        overText.text = "Score: " + score; 
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

  

}
