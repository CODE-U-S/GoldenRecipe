using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class right01 : MonoBehaviour
{
    // 이 메서드를 호출하여 'Main' 씬으로 전환
    public void ChangeToCook01Scene()
    {
        SceneManager.LoadScene("cook01"); // 'cook01' 씬 이름을 사용
    }
}
