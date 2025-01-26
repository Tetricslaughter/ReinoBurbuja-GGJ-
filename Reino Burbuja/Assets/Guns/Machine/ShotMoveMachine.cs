using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMoveMachine : MonoBehaviour
{
    public float maxRotationSpeed = 1000f; // Velocidad máxima de rotación en grados por segundo
    public float accelerationRate = 500f; // Incremento de velocidad por segundo al presionar
    public float decelerationRate = 300f; // Reducción de velocidad por segundo al soltar

    private float currentSpeed = 0f;      // Velocidad actual de rotación

    void Update()
    {
      
        if (Input.GetMouseButton(0)) 
        {
            // Acelera hasta la velocidad máxima
            currentSpeed += accelerationRate * Time.deltaTime;
            currentSpeed = Mathf.Clamp(currentSpeed, 0, maxRotationSpeed);
        }
        else
        {
            // Desacelera gradualmente hasta detenerse
            currentSpeed -= decelerationRate * Time.deltaTime;
            currentSpeed = Mathf.Clamp(currentSpeed, 0, maxRotationSpeed);
        }

        // Rotar el objeto en el eje Z usando la velocidad actual
        transform.Rotate(0, 0, currentSpeed * Time.deltaTime);
    }
}
