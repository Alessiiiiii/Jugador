using UnityEngine;
using TMPro;

public class Inventory : MonoBehaviour
{
    public int itemCount = 0;
    public TextMeshProUGUI itemText;

    public void AddItem()
    {
        itemCount++;
        Debug.Log("¡Objeto añadido al inventario!");
        UpdateUI();
    }

    void UpdateUI()
    {
        if (itemText != null)
        {
            itemText.text = "Objetos: " + itemCount.ToString();
        }
    }
}