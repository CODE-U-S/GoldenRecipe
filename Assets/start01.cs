using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start01 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 19초 후에 Start02 메서드를 호출합니다.
        Invoke("LoadStart02Scene", 18.5f);
    }

    // Update is called once per frame
    void Update()
    {
        // 여기에 필요한 업데이트 로직을 추가할 수 있습니다.
    }

    // start02 씬으로 전환하는 메서드
    void LoadStart02Scene()
    {
        // SceneManager를 사용하여 start02 씬으로 전환합니다.
        SceneManager.LoadScene("start02");
    }
}
