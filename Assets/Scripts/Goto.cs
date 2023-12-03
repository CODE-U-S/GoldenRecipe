using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goto : MonoBehaviour
{
    // Start is called before the first frame update
    public void MoveMain()
    {
        SceneManager.LoadScene("Main");
        Debug.Log("Main으로 전환");
    }

    public void MoveStore()
    {
        SceneManager.LoadScene("Store");
        Debug.Log("Store으로 전환");
    }

    public void MoveShop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void MoveHome()
    {
        SceneManager.LoadScene("Home");
    }
    public void MoveHome_daycount()
    {
         // "Home" 씬으로 이동
        SceneManager.LoadScene("Home");

        // BedYes 메서드 호출
        FindObjectOfType<Bed>().BedYes();
    }

    public void MoveBag()
    {
        SceneManager.LoadScene("Bag");
    }

    public void MoveList()
    {
        SceneManager.LoadScene("List");
    }
    public void MoveSetting()
    {
        SceneManager.LoadScene("Setting");
    }
}
