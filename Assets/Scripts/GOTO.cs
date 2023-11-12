using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOTO : MonoBehaviour
{
    public void MoveMain()
    {
        SceneManager.LoadScene("Main");
        Debug.Log("Main으로 전환");
    }
    public void MoveStore()
    {
        SceneManager.LoadScene("Store");
        Debug.Log("Store로 전환");
    }

    public void MoveHome()
    {
        SceneManager.LoadScene("Home");
        Debug.Log("Home으로 전환");
    }

    public void MoveShop()
    {
        SceneManager.LoadScene("Shop");
        Debug.Log("Shop으로 전환");
    }
}
