using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public TMPro.TextMeshProUGUI healthText;

    void Start()
    {
        playerHealth.onHealthChanged.AddListener(UpdateUI); // Suscribirse al evento
    }

    public void UpdateUI()
    {
        healthText.text = "Salud: " + playerHealth.health.ToString();
    }
}