using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI dialogueText;

    public void ShowDialogue()
    {
        dialogueText.text = "�Hola, jugador! �C�mo est�s?";
    }
}