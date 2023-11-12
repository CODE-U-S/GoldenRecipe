using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class home : MonoBehaviour
{
    private static home instance; // Singleton 패턴을 사용하여 중복 생성 방지

    // Start is called before the first frame update
    void Start()
    {
        // 씬 전환 시에도 파괴되지 않도록 설정
        DontDestroyOnLoad(gameObject);

        // 중복 생성 방지
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Bag 버튼 클릭 시 실행되는 함수
    public void Bag()
    {
        StopMusic();
        SceneManager.LoadScene("Bag");
    }

    // Kitchen 버튼 클릭 시 실행되는 함수
    public void Kitchen()
    {
        StopMusic();
        SceneManager.LoadScene("Main");
    }

    // Myshop 버튼 클릭 시 실행되는 함수
    public void MyShop()
    {
        StopMusic();
        SceneManager.LoadScene("Myshop");
    }

    // Store 버튼 클릭 시 실행되는 함수
    public void Store()
    {
        StopMusic();
        SceneManager.LoadScene("Store");
    }

    // 음악을 중지하는 함수
    private void StopMusic()
    {
        // 여기에 음악 중지 로직 추가
    }
}
