using EasyUI.Toast;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Setting : MonoBehaviour
{
    float sec;
    int day;
    int min_;
    bool tiket = false;
    public void Start()
    {
        if(tiket)
        {
            Toast.Show("쿠폰 적용이 완료되었습니다.", 2f, new Color(8f, 0.7f, 0.0f));
            tiket = false;
        }
        // PlayerPrefs를 이용해 저장된 데이터를 불러옵니다.
        day = PlayerPrefs.GetInt("SavedDay", 1); // 기본 값은 1
        sec = PlayerPrefs.GetFloat("SavedSec", 0f); // 기본 값은 0f
        sec = PlayerPrefs.GetFloat("SavedMin", 0);
    }
    public void DiscordURL()     //링크
    {
        Application.OpenURL("https://discord.gg/pXzaGUrhMR");
        Debug.Log("dicord");
    }

    public void GithubURL()    //링크
    {
        Application.OpenURL("https://github.com/CODE-U-S/GoldenRecipe");
        Debug.Log("github");
    }
    public void LoadSave()
    {
        SceneManager.LoadScene("save", LoadSceneMode.Additive);
        Debug.Log("save");
    }
    public void LoadReset()
    {
        SceneManager.LoadScene("reset", LoadSceneMode.Additive);
        Debug.Log("reset");
    }
    public void LoadTiket()
    {
        SceneManager.LoadScene("tiket", LoadSceneMode.Additive);
        Debug.Log("tiket");
    }

    public void LoadSetting()
    {
        tiket = true;
        if (tiket)
        {
            Toast.Show("쿠폰 적용이 완료되었습니다.", 2f, new Color(8f, 0.7f, 0.0f));
            tiket = false;
        }
        Debug.Log("쿠폰적용완");
        SceneManager.LoadScene("Setting", LoadSceneMode.Additive);
    }
    public void Timer()
    {
        sec += Time.deltaTime;

        if ((int)sec > 59)
        {
            sec = 0;
            min_++;
            if (min_ == 24)
            {
                min_ = 0;
                day++;
                if (day == 30)
                {
                    SaveData(); // 데이터 저장
                    SceneManager.LoadScene("Ending1");
                }
            }
        }
    }

    private void SaveData()
    {
        // PlayerPrefs를 이용해 데이터를 저장합니다.
        PlayerPrefs.SetInt("SavedDay", day);
        PlayerPrefs.SetFloat("SavedSec", sec);
        PlayerPrefs.SetFloat("SavedMin", min_);
        PlayerPrefs.Save(); // 변경된 PlayerPrefs를 저장합니다.
    }
}
