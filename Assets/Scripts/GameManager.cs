using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int lives=3;
    private int score=0;
    public bool isgameover;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Lives=" + lives);
        Debug.Log("score=" + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddLives(int value)
    {
        lives += value;
        if (lives <= 0)
        {
            Debug.Log("Game Over!");
            lives = 0;
            isgameover=true;
        }
        else
        {
            isgameover = false;
        }
        Debug.Log("Lives=" + lives);
    }
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("score=" + score);
        
    }
}
