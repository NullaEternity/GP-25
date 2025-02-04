using UnityEngine;

namespace AE3311
{
    public class TimedJump : MonoBehaviour
    {
        public float jumpForce = 5f;
        public float jumpInterval = 5f;

        private Rigidbody rb;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            InvokeRepeating("Jump", jumpInterval, jumpInterval);
        }

        void Jump()
        {
            if (rb != null)
            {
                rb.angularVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}
