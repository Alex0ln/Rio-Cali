using UnityEngine;

public class SonidoMenu : MonoBehaviour
{
    [SerializeField] private AudioSource musicaMenu;
    private bool sonidoActivo = true;

    void Start()
    {
        sonidoActivo = PlayerPrefs.GetInt("SonidoMenuActivo", 1) == 1;
        musicaMenu.volume = sonidoActivo ? 1f : 0f;
    }

    public void ActivarSonido()
    {
        musicaMenu.volume = 1f;
        sonidoActivo = true;
        PlayerPrefs.SetInt("SonidoMenuActivo", 1);
        Debug.Log("Sonido del menú activado");
    }

    public void DesactivarSonido()
    {
        musicaMenu.volume = 0f;
        sonidoActivo = false;
        PlayerPrefs.SetInt("SonidoMenuActivo", 0);
        Debug.Log("Sonido del menú desactivado");
    }

    public void AlternarSonido()
    {
        if (sonidoActivo)
            DesactivarSonido();
        else
            ActivarSonido();
    }
}