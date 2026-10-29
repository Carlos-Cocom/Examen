using UnityEngine;

public class ZonaSegura : MonoBehaviour
{
    void Start()
    {
        GameObject jugador = GameObject.FindGameObjectWithTag("Player");
        
        if (jugador != null)
        {
            Collider2D colliderZona = GetComponent<Collider2D>();
            Collider2D colliderJugador = jugador.GetComponent<Collider2D>();

            if (colliderZona != null && colliderJugador != null)
            {
                Physics2D.IgnoreCollision(colliderZona, colliderJugador, true);
            }
        }
    }
}