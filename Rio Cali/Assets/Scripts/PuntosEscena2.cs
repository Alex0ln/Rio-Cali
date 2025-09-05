using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static Score Instance { get; private set; }

    [Header("Textos de puntuación")]
    [SerializeField] private TextMeshProUGUI puntosBasuraText;
    [SerializeField] private TextMeshProUGUI puntosPlasticoText;

    [Header("Botón para cambiar de escena")]
    [SerializeField] private GameObject SiguienteEscena;

    [Header("Imagen de felicitación")]
    [SerializeField] private GameObject imagenFelicidades;

    private int puntosBasura = 0;
    private int puntosPlastico = 0;
    private bool elementosMostrados = false;

    void Awake()
    {
        Instance = this;

        if (SiguienteEscena != null)
            SiguienteEscena.SetActive(false);

        if (imagenFelicidades != null)
            imagenFelicidades.SetActive(false);
    }

    public void AddPoints(string tipo, int cantidad)
    {
        if (tipo == "Basura")
        {
            puntosBasura += cantidad;
            if (puntosBasuraText != null)
                puntosBasuraText.text = "" + puntosBasura;
        }
        else if (tipo == "Plasticos")
        {
            puntosPlastico += cantidad;
            if (puntosPlasticoText != null)
                puntosPlasticoText.text = "" + puntosPlastico;
        }
        else
        {
            Debug.LogWarning("Tipo de basura no reconocido: " + tipo);
        }

        VerificarCondiciones();
    }

    private void VerificarCondiciones()
    {
        if (!elementosMostrados && puntosBasura >= 100 && puntosPlastico >= 80)
        {
            elementosMostrados = true;

            if (SiguienteEscena != null)
                SiguienteEscena.SetActive(true);

            if (imagenFelicidades != null)
                imagenFelicidades.SetActive(true);
        }
    }

    public void CambiarEscena()
    {
        SceneManager.LoadScene("3");
    }
}