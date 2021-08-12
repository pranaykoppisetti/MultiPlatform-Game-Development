using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RaceFinish : MonoBehaviour
{
    public GameObject MyCar;
    public GameObject FinishCam;
    public GameObject ViewMode;
    public GameObject CompleteTrig;
    public AudioSource FinishMusic;

    //After finishing the race the car comes to rest and actual view mode would be diabled enabling the finish camera view

    void OnTriggerEnter(Collider other)
    {
        if (ModeTime.isTimeMode == true)
        {
            //we are on race time mode
        }
        else
        {
            RaceFinish raceFinish = this;
            raceFinish.GetComponent<BoxCollider>().enabled = false;
            MyCar.SetActive(false);
#pragma warning disable CS0436 // Type conflicts with imported type
            CompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
#pragma warning restore CS0436 // Type conflicts with imported type
#pragma warning disable CS0436 // Type conflicts with imported type
            MyCar.GetComponent<CarController>().enabled = false;
#pragma warning restore CS0436 // Type conflicts with imported type
#pragma warning disable CS0436 // Type conflicts with imported type
            MyCar.GetComponent<CarUserControl>().enabled = false;
#pragma warning restore CS0436 // Type conflicts with imported type
            MyCar.SetActive(true);
            FinishCam.SetActive(true);
            ViewMode.SetActive(false);
            FinishMusic.Play(); // Play finish music after reaching the finish line
        }
    }

}
