using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public int vidasMaximas = 2;
    private int vidasActuales;

    void Start()
    {
        vidasActuales = vidasMaximas;
    }

    public void RecibirDano(int cantidad)
    {
        vidasActuales -= cantidad;

        if (vidasActuales <= 0)
        {
            Morir();
        }
    }

    private void Morir()
    {
        Destroy(gameObject);
    }
}