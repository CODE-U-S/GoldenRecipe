using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOTO : MonoBehaviour
{
    // Start is called before the first frame update
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

    public void MoveShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void MoveHome()
    {
        SceneManager.LoadScene("Home");
    }

    public void MoveBag()
    {
        SceneManager.LoadScene("Bag");
    }

    public void MoveList()
    {
        SceneManager.LoadScene("List");
    }
}
