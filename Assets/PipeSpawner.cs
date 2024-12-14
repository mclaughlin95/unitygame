using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    public LogicScript logic;

    void Start() {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        spawnPipe();
    }

    void Update() {
        if (timer < spawnRate) {
            timer += Time.deltaTime;
        } else {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe() {
        if (logic.isPlaying()) {
            float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;
            Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint)), transform.rotation);
        }

    }
}