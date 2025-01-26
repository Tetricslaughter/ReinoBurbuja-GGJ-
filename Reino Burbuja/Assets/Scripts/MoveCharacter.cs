using UnityEngine;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    float vertical, horizontal;
    Vector3 moveDirection;
    public Transform cameraTransform; // Referencia a la cámara

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Leer las entradas del jugador
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        // Direccionar según la entrada del jugador
        Vector3 inputDirection = new Vector3(horizontal, 0, vertical).normalized;

        // Ajustar la dirección del movimiento respecto a la cámara
        if (cameraTransform != null)
        {
            Vector3 forward = cameraTransform.forward; // Dirección "adelante" de la cámara
            Vector3 right = cameraTransform.right; // Dirección "derecha" de la cámara

            forward.y = 0f; // Ignorar inclinación vertical
            right.y = 0f;

            forward.Normalize();
            right.Normalize();

            // Calcular la dirección del movimiento
            moveDirection = forward * inputDirection.z + right * inputDirection.x;
        }
        else
        {
            moveDirection = inputDirection; // Si no hay cámara, usar el input directamente
        }
    }

    void FixedUpdate()
    {
        // Aplicar movimiento al Rigidbody
        Vector3 velocity = moveDirection * speed;
        rb.linearVelocity = new Vector3(velocity.x, rb.linearVelocity.y, velocity.z); // Mantener la velocidad en Y (gravedad)
    }
}

