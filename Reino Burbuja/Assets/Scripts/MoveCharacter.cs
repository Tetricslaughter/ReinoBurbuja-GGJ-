using UnityEngine;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    float vertical, horizontal;
    Vector3 moveDirection;
    public Transform cameraTransform; // Referencia a la c�mara

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Leer las entradas del jugador
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        // Direccionar seg�n la entrada del jugador
        Vector3 inputDirection = new Vector3(horizontal, 0, vertical).normalized;

        // Ajustar la direcci�n del movimiento respecto a la c�mara
        if (cameraTransform != null)
        {
            Vector3 forward = cameraTransform.forward; // Direcci�n "adelante" de la c�mara
            Vector3 right = cameraTransform.right; // Direcci�n "derecha" de la c�mara

            forward.y = 0f; // Ignorar inclinaci�n vertical
            right.y = 0f;

            forward.Normalize();
            right.Normalize();

            // Calcular la direcci�n del movimiento
            moveDirection = forward * inputDirection.z + right * inputDirection.x;
        }
        else
        {
            moveDirection = inputDirection; // Si no hay c�mara, usar el input directamente
        }
    }

    void FixedUpdate()
    {
        // Aplicar movimiento al Rigidbody
        Vector3 velocity = moveDirection * speed;
        rb.linearVelocity = new Vector3(velocity.x, rb.linearVelocity.y, velocity.z); // Mantener la velocidad en Y (gravedad)
    }
}

