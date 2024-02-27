using UnityEngine;

namespace CommonFeatures
{
    public class Rotator : MonoBehaviour
    {        
        public float rotationSpeed;
        

        void Update()
        {
            // Rotate the circle around the Z-axis
            transform.Rotate(Vector3.forward * Time.deltaTime * rotationSpeed);
        }


    }
}
