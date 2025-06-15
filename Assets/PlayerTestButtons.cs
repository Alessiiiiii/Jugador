using UnityEngine;

public class PlayerTestButtons : MonoBehaviour
{
    public PlayerHealth playerHealth;

    public void DamagePlayer()
    {
        playerHealth.ChangeHealth(-10);
    }

    public void HealPlayer()
    {
        playerHealth.ChangeHealth(10);
    }
}