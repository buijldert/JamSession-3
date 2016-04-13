using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public static float speed;
    private Vector2 _startPos;
    private float _playerBoundX = 34;
    private float _playerBoundY = 19;
    private CameraShake _camShakeScript;

    void Start()
    {
        _camShakeScript = GameObject.FindWithTag("MainCamera").GetComponent<CameraShake>();
        _startPos = this.transform.position;
    }

    void Update()
    {

        PlayerBounds();

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
            _camShakeScript.Shake();
        }
    }

    void PlayerBounds()
    {
        if (transform.position.x <= -_playerBoundX)
        {
            transform.position = new Vector2(-_playerBoundX, transform.position.y);
        }
        else if (transform.position.x >= _playerBoundX)
        {
            transform.position = new Vector2(_playerBoundX, transform.position.y);
        }
        if (transform.position.y <= -_playerBoundY)
        {
            transform.position = new Vector2(transform.position.x, -_playerBoundY);
        }
        else if (transform.position.y >= _playerBoundY)
        {
            transform.position = new Vector2(transform.position.x, _playerBoundY);
        }
    }

}
