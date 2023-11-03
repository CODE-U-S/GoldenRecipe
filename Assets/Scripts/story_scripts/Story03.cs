using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story03 : MonoBehaviour
{
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
        SceneManager.LoadScene("Story4"); // "Main"은 전환할 씬의 이름입니다.
    }
}
