using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtener el Rigidbody2D
    }

    void Update()
    {
        // Capturar entrada del teclado
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        // Aplicar movimiento con f�sica
        rb.linearVelocity = movement * speed;
    }
}