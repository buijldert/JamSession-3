using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    void Start()
    {
        this.transform.position= new Vector2(transform.position.x, Random.Range(-17, 17));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player1")
        {
            SceneManager.LoadScene("EndScreenBlue");
                    }

        if (other.gameObject.tag == "player2")
        {
            SceneManager.LoadScene("EndScreenYellow");
        }
    }

}
