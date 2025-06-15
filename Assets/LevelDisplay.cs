using UnityEngine;
using TMPro;

public class LevelDisplay : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    private int currentLevel = 1;

    public void UpdateLevel()
    {
        currentLevel++;
        levelText.text = "Nivel: " + currentLevel;
    }
}