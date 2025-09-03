using UnityEngine;

public class CerrarImagen : MonoBehaviour
{
    [SerializeField] private GameObject imagenCanvas;   // La imagen o panel que quieres ocultar
    [SerializeField] private GameObject botonCerrar;    // El botón que también quieres ocultar

    public void Cerrar()
    {
        if (imagenCanvas != null)
            imagenCanvas.SetActive(false);

        if (botonCerrar != null)
            botonCerrar.SetActive(false);
    }
}