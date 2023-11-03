using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoStore : MonoBehaviour
{
    // Start is called before the first frame update
    public void MoveStore()
    {
        SceneManager.LoadScene("Store");
        Debug.Log("Store·Î ÀüÈ¯");
    }
}
