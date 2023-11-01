using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public GameObject leftBtn;
    public GameObject rightBtn;

    private string[] scenes = { "Poot", "Blender", "Pan" };
    private int currentSceneIndex = -1;

    void Start()
    {
        leftBtn = GameObject.Find("leftbtn");
        rightBtn = GameObject.Find("rightbtn");
        DontDestroyOnLoad(leftBtn);
        DontDestroyOnLoad(rightBtn);
    }

    public void RightBtn()
    {
        UnloadPreviousScene(); // 이전 씬 언로드

        currentSceneIndex = (currentSceneIndex + 1) % scenes.Length;
        LoadSceneByIndex(currentSceneIndex); // 새로운 씬 로드
    }

    public void LeftBtn()
    {
        UnloadPreviousScene(); // 이전 씬 언로드

        currentSceneIndex = (currentSceneIndex - 1 + scenes.Length) % scenes.Length;
        LoadSceneByIndex(currentSceneIndex); // 새로운 씬 로드
    }

    private void LoadSceneByIndex(int index)
    {
        string sceneName = scenes[index];
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }

    private void UnloadPreviousScene()
    {
        if (currentSceneIndex != -1)
        {
            string previousSceneName = scenes[currentSceneIndex];
            SceneManager.UnloadSceneAsync(previousSceneName);
        }
    }
}
