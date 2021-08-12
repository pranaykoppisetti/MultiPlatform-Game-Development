using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
#pragma warning disable CS0436 // Type conflicts with imported type
    [RequireComponent(typeof (CarController))]
#pragma warning restore CS0436 // Type conflicts with imported type
    public class CarUserControl : MonoBehaviour
    {
#pragma warning disable CS0436 // Type conflicts with imported type
        private CarController m_Car; // the car controller we want to use
#pragma warning restore CS0436 // Type conflicts with imported type


        private void Awake()
        {
            // get the car controller
#pragma warning disable CS0436 // Type conflicts with imported type
            m_Car = GetComponent<CarController>();
#pragma warning restore CS0436 // Type conflicts with imported type
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}
