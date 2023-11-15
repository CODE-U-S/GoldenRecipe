
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public float day_time = 6.00f;
    public TextMeshProUGUI OpenandClose;
    // Start is called before the first frame update
    void Start()
    {
        if(day_time >= 8 && day_time < 17)
        {
            Open();
            
        } else
        {
            Close();
        }
    }

    void Open()
    {
        OpenandClose.text = "Open";
    }

    void Close()
    {
        OpenandClose.text = "Close";
    }
}
