using UnityEngine;
using System.Collections;

public class PlayerTwoMovement : MonoBehaviour {

    public static float speed2;
    private Vector2 _startPos;

    void Start()
    {
        _startPos = this.transform.position;
    }

    void Update()
    {

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
        }
    }
}
