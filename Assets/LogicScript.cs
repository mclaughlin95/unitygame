using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = score.ToString();
    }

    private void resetScore()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    public void restart()
    {
        resetScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverScreen.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
