using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject WhiteBody;
    public GameObject BlackBody;
    public int CarImport;

    void Start()
    {
        CarImport = GlobalCar.CarType;
        if(CarImport == 1)
        {
            WhiteBody.SetActive(true);
        }

        if(CarImport == 2)
        {
            BlackBody.SetActive(true);
        }
    }

}
