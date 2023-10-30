using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public GameObject leftBtn; // LeftBtn을 연결할 변수
    public GameObject rightBtn; // RightBtn을 연결할 변수

    void Start()
    {
        // LeftBtn과 RightBtn 게임 오브젝트를 찾아 변수에 할당
        leftBtn = GameObject.Find("leftbtn");
        rightBtn = GameObject.Find("rightbtn");

        // LeftBtn과 RightBtn을 다른 씬으로 유지
        DontDestroyOnLoad(leftBtn);
        DontDestroyOnLoad(rightBtn);
    }

    // 메뉴로 화면 전환
    public void RightBtn()
    {
        SceneManager.LoadScene("poot", LoadSceneMode.Additive);
    }

    public void LeftBtn()
    {
        SceneManager.LoadScene("Blender", LoadSceneMode.Additive);
    }
}
