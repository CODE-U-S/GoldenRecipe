using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class home_icon : MonoBehaviour
{
    // Start is called before the first frame update
    public void MoveMain()
    {
        SceneManager.LoadScene("Main");
        Debug.Log("Main���� ��ȯ");
    }
}
