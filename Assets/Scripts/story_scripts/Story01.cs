using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Story01 : MonoBehaviour
{
    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>(); 
    }
    void Start()
    {
        // 1초 후에 ChangeToMainScene 메서드를 호출
        Invoke("ChangeToMainScene", 5.0f);
        Invoke("FadeOut", 4);
    }

    // Update is called once per frame
    void Update()
    {
        
        Color col = image.color;
        if(col.a > 0)
        {
            col.a -= Time.deltaTime;
        }
        image.color = col;

        if(col.a == 0)Thread.Sleep(1000);
        
        Color color = image.color;
        if (color.a < 1 && col.a == 0)
        {
            color.a += Time.deltaTime;
        }
        if(col.a == 0) image.color = color;
    }

    // Main 씬으로 전환하는 메서드
    void ChangeToMainScene()
    {
        SceneManager.LoadScene("Story2"); // "Main"은 전환할 씬의 이름입니다.
    }
}
