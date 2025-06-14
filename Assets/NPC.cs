using UnityEngine;
using UnityEngine.Events;

public class NPC : MonoBehaviour
{
    public UnityEvent onInteracted;  // Evento de interacción

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            onInteracted.Invoke(); // Disparar evento cuando el jugador toca el NPC
        }
    }
}