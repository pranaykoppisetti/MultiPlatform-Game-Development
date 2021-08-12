using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //When clciked on will load to the next scene
    }

    public void QuitGame()
    {
        Application.Quit(); //Exits from the game
        Debug.Log("QUIT!");
    }

}
