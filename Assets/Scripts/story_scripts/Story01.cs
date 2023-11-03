using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Story01 : MonoBehaviour
{
    private Image imageTop;
    void Start()
    {
        // 1초 후에 ChangeToMainScene 메서드를 호출
        Invoke("ChangeToMainScene", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        imageTop = GetComponent<Image>();
    }

    // Main 씬으로 전환하는 메서드
    void ChangeToMainScene()
    {
        SceneManager.LoadScene("Story2"); // "Main"은 전환할 씬의 이름입니다.
    }
}
