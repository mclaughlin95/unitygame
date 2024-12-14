using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour {

    public static bool playing;
    public GameObject gameOverScreen;

    // Score
    public int score;
    public Text scoreText;

    // Count Down Timer
    public GameObject countDownTimer;
    public float timer;
    public Text timerText;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd) {
        score += scoreToAdd;
        scoreText.text = score.ToString();
    }

    public void restart() {
        // Set Score
        score = 0;
        scoreText.text = score.ToString();

        // Set Count Down Timer
        timer = (float)3.99;
        timerText.text = ((int)timer).ToString();

        // Load Scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverScreen.SetActive(true);
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
    }

    public bool isPlaying() {
        return playing;
    }

    void Start() {
        timer = timer = (float)3.99;
        playing = false;
    }

    void Update() {
        playing = (timer <= 0);
        countDownTimer.SetActive(!playing);   
        if (!playing && timer > 1)
        {
            timerText.text = ((int)timer).ToString();
        } 
        else if (timer <= 1 && timer > 0)
        {
            timerText.text = "GO";
        }
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }
}