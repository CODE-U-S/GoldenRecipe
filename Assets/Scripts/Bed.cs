using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bed : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadBed()
    {
        SceneManager.LoadScene("Bed", LoadSceneMode.Additive);
    }
}
