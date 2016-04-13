using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ChangeScene : MonoBehaviour {

    public void MainMenu()
    {
        SceneManager.LoadScene("menu");
    }
    public void Playagain()
    {
        SceneManager.LoadScene("Main");
    }
}
