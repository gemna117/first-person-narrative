using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    [SerializeField]
    private string gameSceneName;

    public void loadgamescene()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void exitgame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
