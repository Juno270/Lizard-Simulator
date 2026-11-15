using UnityEngine;

public class SlopeFixer : MonoBehaviour
{
    private CharacterController controller;
    private float slopeLimit = 45f;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        float slopeAngle = Vector3.Angle(hit.normal, Vector3.up);

        // Check if the slope angle is greater than the limit
        if (slopeAngle > slopeLimit)
        {
            // Calculate the desired movement direction on the slope
            Vector3 slideDirection = new Vector3(hit.normal.x, -hit.normal.y, hit.normal.z);

            // Apply the desired movement direction to the character controller
            controller.Move(slideDirection * Time.deltaTime);
        }
    }
}
