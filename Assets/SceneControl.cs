using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        //�ϥγ����޲z�����J����
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        //���}�C��
        Application.Quit();
    }
}
