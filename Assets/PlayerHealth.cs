using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public UnityEvent onHealthChanged;  // Evento personalizado

    public void ChangeHealth(int value)
    {
        health += value;
        onHealthChanged.Invoke(); // Disparar evento
    }
}