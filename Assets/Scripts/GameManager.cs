using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{
    int score;

    public static GameManager inst;

    public Text scoreText;

    [SerializeField] PlayerMovement playerMove; 

    public void IncrementScore()
    {
        score++;
        scoreText.text = "Score: " + score;
        playerMove.speed += playerMove.speedIncrease; 

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
