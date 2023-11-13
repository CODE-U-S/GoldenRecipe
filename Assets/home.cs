using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class home : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Bag 버튼 클릭 시 실행되는 함수
    public void Bag()
    {
        
        SceneManager.LoadScene("Bag");
    }

    // Kitchen 버튼 클릭 시 실행되는 함수
    public void Kitchen()
    {
        
        SceneManager.LoadScene("Main");
    }

    // Myshop 버튼 클릭 시 실행되는 함수
    public void MyShop()
    {
        
        SceneManager.LoadScene("Myshop");
    }

    // Store 버튼 클릭 시 실행되는 함수
    public void Store()
    {
        
        SceneManager.LoadScene("Store");
    }

    
}
