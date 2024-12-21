using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{

    [SerializeField] private int levelIndex;

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }

    public void Replay()
    {
        SceneManager.LoadScene("Level " + levelIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
