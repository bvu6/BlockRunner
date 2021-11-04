using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameManager score; 
    public Text scoreText;
    // Start is called before the first frame update
    public void Setup()
    {
        gameObject.SetActive(true);
        scoreText.text = "Score: " + score;
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
