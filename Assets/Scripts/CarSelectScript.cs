using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelectScript : MonoBehaviour
{
    public GameObject DayTrack;
    public GameObject NightTrack;

    public void BackButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void PlayButton()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        if(GlobalTrack.TrackType == 1)
        {
            SceneManager.LoadScene(4);
        }

        if(GlobalTrack.TrackType == 2)
        {
            SceneManager.LoadScene(5);
        }
    }

    public void NextButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
