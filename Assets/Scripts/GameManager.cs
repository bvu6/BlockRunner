using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    public int score;

    public static GameManager inst;

    public Text scoreText;

    public void IncrementScore()
    {
        score++;
        scoreText.text = "Score: " + score; 
    }
    // Start is called before the first frame update
    private void Awake()
    {
        inst = this; 
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}