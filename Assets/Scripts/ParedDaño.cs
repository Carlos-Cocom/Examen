using UnityEngine;

public class ParedDaño : MonoBehaviour
{
    public int dano = 1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            VidaJugador vida = collision.gameObject.GetComponent<VidaJugador>();
            if (vida != null)
            {
                vida.RecibirDano(dano);
            }
        }

    }

}
