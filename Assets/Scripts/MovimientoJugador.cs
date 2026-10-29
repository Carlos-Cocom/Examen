using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;
    
    private Rigidbody2D rb;
    private Vector2 direccionMovimiento;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        Vector2 nuevoInput = value.Get<Vector2>();
        
        if (nuevoInput != Vector2.zero)
        {
            direccionMovimiento = nuevoInput.normalized;
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = direccionMovimiento * velocidad; 
    }
}