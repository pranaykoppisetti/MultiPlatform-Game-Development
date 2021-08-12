using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalTrack : MonoBehaviour
{
    public static int TrackType;
    public GameObject TrackingWindow;

    public void DayTrack()
    {
        TrackType = 1;
        TrackingWindow.SetActive(true);
    }

    public void NightTrack()
    {
        TrackType = 2;
        TrackingWindow.SetActive(true);
    }
}
