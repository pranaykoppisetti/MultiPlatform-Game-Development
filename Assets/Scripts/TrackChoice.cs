using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrackChoice : MonoBehaviour
{
    public GameObject DayTrack;
    public GameObject NightTrack;
    public int TrackImport;

    void Start()
    {
        if(TrackImport == 1)
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneAt(3));
        }

        if(TrackImport == 2)
        {
            SceneManager.SetActiveScene(SceneManager.GetSceneAt(4));
        }
    }
}
