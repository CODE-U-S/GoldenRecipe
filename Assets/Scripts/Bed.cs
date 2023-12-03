using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bed : MonoBehaviour
{

    int day = 30;
    int money;
    int golden_recipe;
    [SerializeField]
    TextMeshProUGUI _DaysText;
    

    void Start()
    {
        LoadSavedData(); // 저장된 데이터 불러오기
        UpdateDaysText(); // 텍스트 업데이트
        //if(day == 0)
        //{
        //    EndingScene();
        //}
    }

    public void LoadBed()
    {
        SceneManager.LoadScene("Bed", LoadSceneMode.Additive);
    }

    public void BedYes()
    {
        day -= 1;
        //초기화용 day = 30;
        PlayerPrefs.SetInt("SavedDay", day);
        Debug.Log("프린트 완");
        SaveData(); // 데이터 저장
        SceneManager.LoadScene("Home");
    }

    private void LoadSavedData()
    {
        day = PlayerPrefs.GetInt("SavedDay", 30);
        // 저장된 데이터 불러오기, 기본 값은 30
        money = PlayerPrefs.GetInt("Money");
        Debug.Log(money);
    }

    private void SaveData()
    {
        PlayerPrefs.Save();// 변경된 PlayerPrefs를 저장합니다.
    }

    private void UpdateDaysText()
    {
        _DaysText.text = string.Format("D-{0:D1}", day);
    }

    private void EndingScene()
    {
        money = 40000;
        if(money >= 40000)
        {
            SceneManager.LoadScene("Ending1");
        }
        else if (golden_recipe >= 1)
        {
            SceneManager.LoadScene("Ending2");
        }
        else
        {
            SceneManager.LoadScene("Ending3");
        }
    }
}
