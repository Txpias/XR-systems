using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;  
    public int score = 0;
    public int arrowCount = 0;
    private int maxArrows = 10;

    public bool CanShoot()
    {
        return arrowCount < maxArrows;
    }

    public void AddPoints(int points)
    {
        if (arrowCount >= maxArrows) return;

        score += points;
        UpdateScoreText();
    }

    public void ArrowShot()
    {
        arrowCount++;
        if (arrowCount >= maxArrows)
        {
            EndGame();
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    private void EndGame()
    {
        if (score < 50)
        {
            scoreText.color = Color.red;
            scoreText.text = "Game over!\nyou can do better\nFinal score: " +  score;
        }else
        {
        scoreText.color = Color.green;
        scoreText.text = "Good job!\nfinal score: " + score;
        }
    }
}
