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
        // 1�� �Ŀ� ChangeToMainScene �޼��带 ȣ��
        Invoke("ChangeToMainScene", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        imageTop = GetComponent<Image>();
    }

    // Main ������ ��ȯ�ϴ� �޼���
    void ChangeToMainScene()
    {
        SceneManager.LoadScene("Story2"); // "Main"�� ��ȯ�� ���� �̸��Դϴ�.
    }
}
