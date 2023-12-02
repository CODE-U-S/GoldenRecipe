using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class lists : MonoBehaviour
{
    
    public void MoveLevel1()
    {
        SceneManager.LoadScene("level1");
    }

    public void MoveLevel2()
    {
        SceneManager.LoadScene("level2");
    }

    public void LoadClose()
    {
        SceneManager.LoadScene("close", LoadSceneMode.Additive);
    }
}
