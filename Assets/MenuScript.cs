using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
    void Start() {
        
    }

    void Update() {
        
    }

    public void play() {
        SceneManager.LoadScene("GameScene");
    }
}
