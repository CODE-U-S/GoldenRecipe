using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story06 : MonoBehaviour
{
    void Start()
    {
        // 1�� �Ŀ� ChangeToMainScene �޼��带 ȣ��
        Invoke("ChangeToMainScene", 1.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Main ������ ��ȯ�ϴ� �޼���
    void ChangeToMainScene()
    {
        SceneManager.LoadScene("Story7"); // "Main"�� ��ȯ�� ���� �̸��Դϴ�.
    }
}
