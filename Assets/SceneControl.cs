using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        //使用場景管理器載入場景
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        //離開遊戲
        Application.Quit();
    }
}
