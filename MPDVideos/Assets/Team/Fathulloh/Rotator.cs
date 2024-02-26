using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Commonfeatures
{
    public class Rotator : MonoBehaviour
    {
        //public enum RotateAxis { forX, forY, forZ };
        //public RotateAxis CurrentAxis;

        public float rotationSpeed;


        void Start()
        {

        }


        void Update()
        {
            // Rotate the circle around the Z-axis
            transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
        }


    }
}
