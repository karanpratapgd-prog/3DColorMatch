using UnityEngine;

public class GTAThirdPersonCamera : MonoBehaviour
{
    public Transform target;
    public float distance = 6f;
    public float height = 3f;
    public float mouseSensitivity = 3f;
    public float smoothSpeed = 10f;

    float yaw;

    void LateUpdate()
    {
        if (!target) return;

        yaw += Input.GetAxis("Mouse X") * mouseSensitivity;

        Quaternion rotation = Quaternion.Euler(0, yaw, 0);
        Vector3 desiredPosition = target.position
                                  - rotation * Vector3.forward * distance
                                  + Vector3.up * height;

        transform.position = Vector3.Lerp(
            transform.position,
            desiredPosition,
            smoothSpeed * Time.deltaTime
        );

        transform.LookAt(target.position + Vector3.up * 1.5f);
    }
}
