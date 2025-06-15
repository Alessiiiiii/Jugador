using UnityEngine;

public class GameUI : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject pauseScreen;

    public void ShowStart()
    {
        startScreen.SetActive(true);
        pauseScreen.SetActive(false);
    }

    public void ShowPause()
    {
        pauseScreen.SetActive(true);
        startScreen.SetActive(false);
    }
}