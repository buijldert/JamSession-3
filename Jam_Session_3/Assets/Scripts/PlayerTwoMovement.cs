using UnityEngine;
using System.Collections;

public class PlayerTwoMovement : MonoBehaviour {

    public static float speed2;
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

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed2);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed2);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * speed2);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * speed2);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player1")
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
