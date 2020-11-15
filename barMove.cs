using UnityEngine;

public class barMove : MonoBehaviour {
    private Rigidbody2D _rigid2D;

    private void Start() {
        _rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update() {
        _rigid2D.AddForce(transform.right * -0.1f);
        transform.Translate(-0.05f, 0, 0);
        if (transform.position.x < -10.0f) Destroy(gameObject);
    }
}