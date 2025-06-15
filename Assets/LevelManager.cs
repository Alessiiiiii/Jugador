using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public UnityEvent onLevelChanged;

    public void ChangeLevel()
    {
        onLevelChanged.Invoke();
    }
}