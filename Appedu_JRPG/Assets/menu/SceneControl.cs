using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void DelayLoadScene()
    {
        Invoke("LoadScene", 1.5f);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("testing scenarios");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void DelayQuitGame()
    {
        Invoke("QuitGame", 1.5f);
    }
}
