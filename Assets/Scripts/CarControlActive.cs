using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{
    public GameObject AutoCar01;

    void Start()
    {
        AutoCar01.GetComponent<CarAIControl>().enabled = true;
    }
}
