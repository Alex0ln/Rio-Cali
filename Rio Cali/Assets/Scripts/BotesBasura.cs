using UnityEngine;

public class TrashBin : MonoBehaviour
{
    public string acceptedTag; // Ej: "Basura" o "Plastico"

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag(acceptedTag))
        {
            DraggableTrash trash = other.GetComponent<DraggableTrash>();
            if (trash != null && trash.isDragging)
            {
                Score.Instance.AddPoints(acceptedTag, 20);
                Destroy(other.gameObject);
            }
        }
    }
}