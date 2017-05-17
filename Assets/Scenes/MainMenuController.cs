using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class MainMenuController : MonoBehaviour {

    public void Play()
    {
        Debug.Log("Play pressed");
        SceneManager.LoadScene(5);
    }

    public void Quit()
    {
        Debug.Log("Quit pressed");
        Application.Quit();
    }

}
