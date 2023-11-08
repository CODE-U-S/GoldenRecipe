using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public GameObject leftBtn;
    public GameObject rightBtn;

    private string[] scenes = { "Poot", "Blender", "Pan", "board" }; // Ensure "board" scene is the first one

    private int currentSceneIndex = -1;

    void Start()
    {
        leftBtn = GameObject.Find("leftbtn");
        rightBtn = GameObject.Find("rightbtn");
        DontDestroyOnLoad(leftBtn);
        DontDestroyOnLoad(rightBtn);

        // Find the index of the "board" scene in the array and set it as the starting scene
        currentSceneIndex = System.Array.IndexOf(scenes, "board");
        LoadSceneByIndex(currentSceneIndex);
    }

    public void RightBtn()
    {
        UnloadPreviousScene(); // Unload the previous scene

        currentSceneIndex = (currentSceneIndex + 1) % scenes.Length;
        LoadSceneByIndex(currentSceneIndex); // Load the new scene
    }

    public void LeftBtn()
    {
        UnloadPreviousScene(); // Unload the previous scene

        currentSceneIndex = (currentSceneIndex - 1 + scenes.Length) % scenes.Length;
        LoadSceneByIndex(currentSceneIndex); // Load the new scene
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
