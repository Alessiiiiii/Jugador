using UnityEngine;
using UnityEngine.Events;

public class Collectible : MonoBehaviour
{
    public UnityEvent onCollected;  // Evento de recolecci�n

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            onCollected.Invoke();
            Destroy(gameObject);
        }
    }
}
