using UnityEngine;

public class BirdScript : MonoBehaviour {

    public Rigidbody2D myRigidbody;
    public float flapStrength = 60;
    public LogicScript logic;
    public bool birdIsAlive = true;

    public AudioSource audioSource;
    public AudioClip jumpSound;
    public AudioClip smackSound;

    void Start() {
        audioSource.clip = jumpSound;
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        myRigidbody.constraints = RigidbodyConstraints2D.FreezePositionY;
    }

    void Update() {
        bool isPlaying = logic.isPlaying();
        if (isPlaying) {
            myRigidbody.constraints = RigidbodyConstraints2D.None;
            myRigidbody.WakeUp();
        }
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive && isPlaying) {
            myRigidbody.linearVelocity = Vector2.up * this.flapStrength;
            audioSource.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (birdIsAlive) {
            audioSource.clip = smackSound;
            audioSource.Play();
            birdIsAlive = false;
            logic.gameOver();
        }
    }

}