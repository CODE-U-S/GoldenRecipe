using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // SceneManager를 사용하기 위해 필요한 네임스페이스

public class StartSceneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 1초 후에 ChangeToMainScene 메서드를 호출
        Invoke("ChangeToMainScene", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Main 씬으로 전환하는 메서드
    void ChangeToMainScene()
    {
        SceneManager.LoadScene("Main"); // "Main"은 전환할 씬의 이름입니다.
    }
}
