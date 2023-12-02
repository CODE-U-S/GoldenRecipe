using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum ItemType
{
    Water,
    Garlic,
    Potato,
    Rice,
    Carrot,
    CurryPowder
}

public class Main : MonoBehaviour
{
    public GameObject leftBtn;
    public GameObject rightBtn;
    public AudioClip buttonClickSound; // 추가: 버튼 클릭 사운드

    // 재료 프리팹
    public GameObject waterPrefab;
    public GameObject garlicPrefab;
    public GameObject potatoPrefab;
    public GameObject ricePrefab;
    public GameObject carrotPrefab;
    public GameObject curryPowderPrefab;

    public Transform content;

    private string[] scenes = { "Poot", "Blender", "Pan", "board" }; // "board" 씬이 첫 번째여야 합니다.

    private int currentSceneIndex = -1;

    void Start()
    {
        leftBtn = GameObject.Find("leftbtn");
        rightBtn = GameObject.Find("rightbtn");
        DontDestroyOnLoad(leftBtn);
        DontDestroyOnLoad(rightBtn);

        // "board" 씬의 인덱스를 찾아 시작 씬으로 설정합니다.
        currentSceneIndex = System.Array.IndexOf(scenes, "board");
        LoadSceneByIndex(currentSceneIndex);

        if (content == null)
        {
            Debug.LogError("Content is not set in the inspector!");
            return;
        }

        InstantiateItemPrefabs(ItemType.Water, waterPrefab);
        InstantiateItemPrefabs(ItemType.Garlic, garlicPrefab);
        InstantiateItemPrefabs(ItemType.Potato, potatoPrefab);
        InstantiateItemPrefabs(ItemType.Rice, ricePrefab);
        InstantiateItemPrefabs(ItemType.Carrot, carrotPrefab);
        InstantiateItemPrefabs(ItemType.CurryPowder, curryPowderPrefab);
    }

    private void InstantiateItemPrefabs(ItemType itemType, GameObject prefab)
    {
        int itemCount = DataManager.Instance.GetItemCount(itemType);

        for (int i = 0; i < itemCount; i++)
        {
            GameObject itemInstance = Instantiate(prefab, content);
            // 여기에서 필요한 초기화 코드를 추가하세요.
        }
    }

    public void RightBtn()
    {
        UnloadPreviousScene(); // 이전 씬을 언로드합니다.

        currentSceneIndex = (currentSceneIndex + 1) % scenes.Length;
        LoadSceneByIndex(currentSceneIndex); // 새로운 씬을 로드합니다.

        PlayButtonClickSound(); // 버튼 클릭 사운드를 재생합니다.
    }

    public void LeftBtn()
    {
        UnloadPreviousScene(); // 이전 씬을 언로드합니다.

        currentSceneIndex = (currentSceneIndex - 1 + scenes.Length) % scenes.Length;
        LoadSceneByIndex(currentSceneIndex); // 새로운 씬을 로드합니다.

        PlayButtonClickSound(); // 버튼 클릭 사운드를 재생합니다.
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

    private void PlayButtonClickSound()
    {
        if (buttonClickSound != null)
        {
            AudioSource.PlayClipAtPoint(buttonClickSound, Camera.main.GetComponent<AudioListener>().transform.position);
            // 주의: 이 방법은 2D 사운드 효과를 제공하며, AudioListener 위치에서 사운드를 재생합니다.
            // 만약 다른 사운드 효과가 필요하면, 적절한 AudioSource를 만들어 사용하세요.
        }
    }
}
