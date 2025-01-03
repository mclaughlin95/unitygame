using UnityEngine;

public class PipeMoveScript : MonoBehaviour {

    public float moveSpeed = 5;
    public float deadZone = -45;

    void Update() {
        transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone) {
            Destroy(gameObject);
        }
    }
}