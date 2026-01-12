using UnityEngine;

public class BaseColor : MonoBehaviour
{
    public ColorType zoneColor;

    private void OnTriggerEnter(Collider other)
    {
        PickableObject obj = other.GetComponentInParent<PickableObject>();
        if (obj == null) return;

        if (obj.colorType == zoneColor)
        {
            Destroy(obj.transform.root.gameObject);
        }

        if (ScoreManager.Instance == null)
        {
            Debug.LogWarning("ScoreManager not found – skipping score");
            return;
        }

        if (obj.colorType == zoneColor)
        {
            ScoreManager.Instance.AddScore(10);
        }
        else
        {
            ScoreManager.Instance.AddScore(-5);
        }
    }
}
