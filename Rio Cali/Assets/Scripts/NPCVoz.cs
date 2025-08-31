using UnityEngine;

public class NPCVozDesdeObjeto : MonoBehaviour
{
    public AudioSource fuenteDeAudio;
    private bool yaHablo = false;

    void OnTriggerEnter(Collider other)
    {
        if (!yaHablo && other.CompareTag("Player"))
        {
            fuenteDeAudio.Play();
            yaHablo = true;
            Debug.Log("NPC habló desde objeto vacío");
        }
    }
}