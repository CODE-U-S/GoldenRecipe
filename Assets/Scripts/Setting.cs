using EasyUI.Toast;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class settingss : MonoBehaviour
{
    float sec;
    int day;
    int min_;
    bool tiket = false;
    private string playerName;
    
    [SerializeField]
    private TextMeshProUGUI couponText;
    public void Start()
    {
        if(tiket)
        {
            Toast.Show("쿠폰 적용이 완료되었습니다.", 2f, new Color(8f, 0.7f, 0.0f));
            tiket = false;
        }
        // PlayerPrefs를 이용해 저장된 데이터를 불러옵니다.
        day = PlayerPrefs.GetInt("SavedDay", 1); //기본값은 1
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
        SceneManager.LoadScene("resets", LoadSceneMode.Additive);
        Debug.Log("resets");
    }
    public void LoadTiket()
    {
        SceneManager.LoadScene("tiket", LoadSceneMode.Additive);
        Debug.Log("tiket");
    }

    public void LoadSetting_tiket()
    {
        
        if (couponText != null)
        {
            tiket = true;
            Toast.Show("쿠폰 적용이 완료되었습니다.", 2f, new Color(8f, 0.7f, 0.0f));
            Debug.Log("쿠폰적용완");

            // DataManager 인스턴스에 접근하여 money 속성을 업데이트합니다.
            DataManager.Instance.Money += 30000;

            SceneManager.LoadScene("Setting", LoadSceneMode.Additive);
            Invoke("sleep", 3);
        }
        else
        {
            Debug.Log("쿠폰 적용 실패");
        }

    }
    public void sleep(){
        SceneManager.LoadScene("Setting");
    }
}