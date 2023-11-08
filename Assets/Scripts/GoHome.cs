using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoHome : MonoBehaviour
{
    // Start is called before the first frame update
    public void MoveMain()
    {
        SceneManager.LoadScene("Main");
        Debug.Log("Main으로 전환");
    }
}
