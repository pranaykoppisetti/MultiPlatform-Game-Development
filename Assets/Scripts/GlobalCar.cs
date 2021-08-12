using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalCar : MonoBehaviour
{
    public static int CarType; //1 = White, 2 = Black
    public GameObject TrackWindow;

    public void WhiteCar()
    {
        CarType = 1;
        TrackWindow.SetActive(true);
    }

    public void BlackCar()
    {
        CarType = 2;
        TrackWindow.SetActive(true);
    }
}
