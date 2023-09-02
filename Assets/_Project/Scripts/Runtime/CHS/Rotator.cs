using UnityEngine;

namespace CHS.UnityCI
{
    public class Rotator : MonoBehaviour
    {
        public float rotationSpeed = 50.0f; // You can adjust the default speed in the Inspector.

        void Update()
        {
            // Rotate the cube around its center based on the rotationSpeed and deltaTime.
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }
    }
}