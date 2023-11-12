using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOTO : MonoBehaviour
{
    public void MoveMain()
    {
        SceneManager.LoadScene("Main");
        Debug.Log("Main���� ��ȯ");
    }
    public void MoveStore()
    {
        SceneManager.LoadScene("Store");
        Debug.Log("Store�� ��ȯ");
    }

    public void MoveHome()
    {
        SceneManager.LoadScene("Home");
        Debug.Log("Home���� ��ȯ");
    }

    public void MoveShop()
    {
        SceneManager.LoadScene("Shop");
        Debug.Log("Shop���� ��ȯ");
    }
}
