using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public Text healthText;

    void Start()
    {
        playerHealth.onHealthChanged.AddListener(UpdateUI); // Suscribirse al evento
    }

    void UpdateUI()
    {
        healthText.text = "Salud: " + playerHealth.health.ToString();
    }
}