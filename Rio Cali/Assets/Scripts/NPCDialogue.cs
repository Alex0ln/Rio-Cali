using UnityEngine;

public class NPCDialogue : MonoBehaviour
{
    public GameObject dialoguePanel;   
    public string dialogueText;       
    public TMPro.TextMeshProUGUI textComponent; 

    private void Start()
    {
        if (dialoguePanel != null)
            dialoguePanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (dialoguePanel != null)
            {
                dialoguePanel.SetActive(true);
                textComponent.text = dialogueText;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (dialoguePanel != null)
                dialoguePanel.SetActive(false);
        }
    }
}
