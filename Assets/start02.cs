using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 3초 후에 LoadMainScene 메서드를 호출합니다.
        Invoke("LoadMainScene", 2.5f);
    }

    // Update is called once per frame
    void Update()
    {
        // 여기에 필요한 업데이트 로직을 추가할 수 있습니다.
    }

    // main 씬으로 전환하는 메서드
    void LoadMainScene()
    {
        // SceneManager를 사용하여 main 씬으로 전환합니다.
        SceneManager.LoadScene("main");
    }
}
