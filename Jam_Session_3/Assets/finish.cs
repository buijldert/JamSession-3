using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player1")
        {
            //SceneManager.LoadScene("2");
            Debug.Log("player 1");
                    }

        if (other.gameObject.tag == "player2")
        {
            //SceneManager.LoadScene("2");
            Debug.Log("player 2");


        }
    }

}
