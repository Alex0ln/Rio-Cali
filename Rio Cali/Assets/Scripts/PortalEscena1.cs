using UnityEngine;

public class Teletransportador : MonoBehaviour
{
    public Transform destino; // Asigna el destino en el Inspector
    public float distanciaActivacion = 2f; // Distancia mínima para activar

    void Update()
    {
        GameObject jugador = GameObject.FindGameObjectWithTag("Player");
        if (jugador != null)
        {
            float distancia = Vector3.Distance(transform.position, jugador.transform.position);
            if (distancia < distanciaActivacion)
            {
                jugador.transform.position = destino.position;
                Debug.Log("Teletransportado al destino");
            }
        }
    }
}