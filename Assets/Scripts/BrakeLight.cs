using System;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Car
{
    public class BrakeLight : MonoBehaviour
    {
#pragma warning disable CS0436 // Type conflicts with imported type
        public CarController car; // reference to the car controller, must be dragged in inspector
#pragma warning restore CS0436 // Type conflicts with imported type

        private Renderer m_Renderer;


        private void Start()
        {
            m_Renderer = GetComponent<Renderer>();
        }


        private void Update()
        {
            // enable the Renderer when the car is braking, disable it otherwise.
            m_Renderer.enabled = car.BrakeInput > 0f;
        }
    }
}
