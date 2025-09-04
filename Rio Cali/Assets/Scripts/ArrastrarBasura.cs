using UnityEngine;

public class DraggableTrash : MonoBehaviour
{
    private Vector3 offset;
    private float zCoord;
    public bool isDragging = false;

    void OnMouseDown()
    {
        zCoord = Camera.main.WorldToScreenPoint(transform.position).z;
        offset = transform.position - GetMouseWorldPos();
        isDragging = true;
    }

    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + offset;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = zCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
}