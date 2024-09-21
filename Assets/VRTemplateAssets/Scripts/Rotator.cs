using UnityEngine;

namespace Unity.VRTemplate
{
    /// <summary>
    /// Rotates this object at a user defined speed
    /// </summary>
    public class Rotator : MonoBehaviour
    {
        [SerializeField, Tooltip("Angular velocity in degrees per second")]
        Vector3 m_Velocity;

        void Update()
        {
            Transform myTransform = this.transform;
            myTransform.Rotate(m_Velocity * Time.deltaTime);
        }
    }
}
