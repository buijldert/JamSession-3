using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public static float speed;
    private Vector2 _startPos;

    void Start()
    {
        _startPos = this.transform.position;
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-Vector2.right * speed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(-Vector2.up * speed);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player2")
        {
            transform.position = _startPos;
        }
    }
}
