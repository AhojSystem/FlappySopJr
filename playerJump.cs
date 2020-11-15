using UnityEngine;
using UnityEngine.SceneManagement;

public class playerJump : MonoBehaviour {
    private Rigidbody2D rigid2D;
    private float jumpForce = 320.0f;
    private int count = 0;

    void Start() {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            rigid2D.AddForce(transform.up * jumpForce);
            //GetComponent<AudioSource>().Play();
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.name != "col(Clone)") {
            Debug.Log(other.name);
            SceneManager.LoadScene("Scenes/GameOver");
        }
    }
}