using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject eButtonUI; // Asigna el botón en el Inspector
    private TrashTrigger currentTrash;

    void Update()
    {
        if (currentTrash != null)
        {
            eButtonUI.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                currentTrash.Collect();
                eButtonUI.SetActive(false);
                currentTrash = null;
            }
        }
        else
        {
            eButtonUI.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trash"))
        {
            currentTrash = other.GetComponent<TrashTrigger>();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Trash") && currentTrash != null)
        {
            eButtonUI.SetActive(false);
            currentTrash = null;
        }
    }
}