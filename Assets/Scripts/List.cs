using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
public class List : MonoBehaviour
{
    
    public void MoveLevel1()
    {
        SceneManager.LoadScene("Level 1");
        Debug.Log("Level 1으로 전환");
    }

    public void MoveLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void LoadClose()
    {
        SceneManager.LoadScene("close", LoadSceneMode.Additive);
    }
}
