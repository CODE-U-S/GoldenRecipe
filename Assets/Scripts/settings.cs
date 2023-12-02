using EasyUI.Toast;
using UnityEngine;
using UnityEngine.SceneManagement;

public class settings : MonoBehaviour
{
    int day;
    bool tiket = false;
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
    
}
