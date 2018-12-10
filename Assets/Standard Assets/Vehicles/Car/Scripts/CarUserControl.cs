using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        public AxisTouchButton axisaccl;
        public AxisTouchButton axisaccl2;
        
       //public Onbreak brek;
        
        private CarController m_Car; // the car controller we want to use


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
    
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            /*  float b = axisaccl.Onbreak();
               float v = axisaccl.Onaccelrate();*/
            /*float b = -axisaccl2.Onaccelrate();
            float v = axisaccl.Onaccelrate();*/
            float b = -PlayerPrefs.GetFloat("accl");
            float v = PlayerPrefs.GetFloat("accl");
           
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h,v, b, handbrake);
#else
            m_Car.Move(h,v, b, 0f);
#endif
        }
    }
}
