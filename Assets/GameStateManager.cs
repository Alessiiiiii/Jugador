using UnityEngine;
using UnityEngine.Events;

public class GameStateManager : MonoBehaviour
{
    public UnityEvent onGameStarted;
    public UnityEvent onGamePaused;

    public void StartGame() => onGameStarted.Invoke();
    public void PauseGame() => onGamePaused.Invoke();
}