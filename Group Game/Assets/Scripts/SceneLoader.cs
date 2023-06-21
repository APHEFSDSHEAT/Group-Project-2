using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadStartScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadWinScreen()
    {
        SceneManager.LoadScene("WinScreen");
    }

    public void LoadGameScene1_1()
    {
        SceneManager.LoadScene("1-1");
    }

    public void LoadGameScene1_2()
    {
        SceneManager.LoadScene("1-2");
    }

    public void LoadGameScene1_3()
    {
        SceneManager.LoadScene("1-3");
    }
    public void LoadGameScene2_1()
    {
        SceneManager.LoadScene("2-1");
    }
    public void LoadGameScene2_2()
    {
        SceneManager.LoadScene("2-2");
    }
    public void LoadGameScene3_1()
    {
        SceneManager.LoadScene("3-1");
    }
    public void LoadGameScene3_2()
    {
        SceneManager.LoadScene("3-2");
    }
    public void LoadGameScene3_3()
    {
        SceneManager.LoadScene("3-3");
    }
    public void LoadGameScene4_1()
    {
        SceneManager.LoadScene("4-1");
    }
    public void LoadGameScene4_2()
    {
        SceneManager.LoadScene("4-2");
    }
    public void LoadGameScene4_3()
    {
        SceneManager.LoadScene("4-3");
    }
    public void LoadGameScene4_4()
    {
        SceneManager.LoadScene("4-4");
    }

    public void Drowning()
    {
        SceneManager.LoadScene("DrownScene");
    }

    public void LoseScene()
    {
        SceneManager.LoadScene(1);
    }
}
