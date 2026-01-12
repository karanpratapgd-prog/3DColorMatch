using UnityEngine;

public class PickableObject : MonoBehaviour
{
    public ColorType colorType;

    public void PickUp(Transform holder)
    {
        Collider col = GetComponent<Collider>();
        Rigidbody rb = GetComponent<Rigidbody>();

        if (col != null)
            col.enabled = false;

        if (rb != null)
            rb.isKinematic = true;

        transform.SetParent(holder);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.identity;
    }
}

public enum ColorType
{
    Red,
    Green,
    Blue,
    Yellow
}
