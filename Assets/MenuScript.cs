using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

    // Menu Music
    public AudioSource audioSource;
    public AudioClip music;

    void Start() {
        audioSource.clip = music;
        audioSource.loop = true;
        audioSource.Play();
    }

    void Update() {
        
    }

    public void play() {
        SceneManager.LoadScene("GameScene");
    }

    public void exit() {
        Application.Quit();
    }
}
