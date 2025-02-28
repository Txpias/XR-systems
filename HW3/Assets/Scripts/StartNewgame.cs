using UnityEngine;

public class StartNewgame : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public ScoreManager scoreManager;
    
    public void restartGame()
    {
        scoreManager.scoreText.color = new Color(0.7f, 0f, 0.7f);
        scoreManager.score = 0;
        scoreManager.arrowCount = 0;
        scoreManager.scoreText.text = "Score:" + scoreManager.score;
    }
}
