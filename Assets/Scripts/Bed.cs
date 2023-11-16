using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Bed : MonoBehaviour
{
    float sec;
    int min_;
    int day = 1;

    [SerializeField]
    TextMeshProUGUI _TimerText;
    [SerializeField]
    TextMeshProUGUI _DaysText;
    // Start is called before the first frame update
    public void LoadBed()
    {
        SceneManager.LoadScene("Bed", LoadSceneMode.Additive);
    }
    public void Update()
    {
        Timer();
    }
    public void Timer()
    {
        sec += Time.deltaTime;
        _TimerText.text = string.Format("{0:D2}:{1:D2}", min_, (int)sec);

        if((int)sec > 59)
        {
            sec = 0;
            min_++;
            if(min_ == 24)
            {
                min_ = 0;
                day++;
                if(day == 30)
                {
                    SceneManager.LoadScene("Ending1");
                }
            }
        }
        _DaysText.text = string.Format("{0:D1}¹øÂ°³¯", day);
    }
}
