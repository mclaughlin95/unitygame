using UnityEngine;

public class BirdScript : MonoBehaviour {

    public Rigidbody2D myRigidbody;
    public float flapStrength = 60;
    public LogicScript logic;
    public bool birdIsAlive = true;

    void Start() {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.linearVelocity = Vector2.up * this.flapStrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
