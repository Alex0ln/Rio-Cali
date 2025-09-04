using UnityEngine;

[RequireComponent(typeof(Collider))]
public class TrashTrigger : MonoBehaviour
{
    [Tooltip("Cantidad de puntos que otorga esta basura al recogerla.")]
    public int points = 10;

    private bool isCollected = false;

    public void Collect()
    {
        if (isCollected) return; // Evita doble recolección
        isCollected = true;

        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
        if (scoreManager != null)
        {
            scoreManager.AddPoints(points);
        }
        else
        {
            Debug.LogWarning("ScoreManager no encontrado en la escena.");
        }

        Destroy(gameObject); // Elimina la basura del mapa
    }
}