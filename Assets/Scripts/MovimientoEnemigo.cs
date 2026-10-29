using UnityEngine;

public class MovimientoEnemigo : MonoBehaviour
{
    public float velocidad = 4f;
    public int dano = 1;
    public Vector2 direccionInicial = new Vector2(1f, 1f);

    private Rigidbody2D rb;
    private Vector2 direccionActual;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        direccionActual = direccionInicial.normalized; 
    }

    void FixedUpdate()
    {
        rb.linearVelocity = direccionActual * velocidad;
    }

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

        Vector2 normalContacto = collision.GetContact(0).normal;
        direccionActual = Vector2.Reflect(direccionActual, normalContacto).normalized;
    }
}