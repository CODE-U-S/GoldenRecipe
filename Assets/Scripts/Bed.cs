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
    [SerializeField]
    TextMeshProUGUI _MoneyText;  // 돈을 표시할 TextMeshProUGUI 필드
    

    void Start()
    {
        LoadSavedData(); // 저장된 데이터 불러오기
        UpdateDaysText(); // 텍스트 업데이트
        UpdateMoneyText();         // 돈 텍스트 업데이트
        if(day == 0)
        {
            EndingScene();
        }
    }

    public void LoadBed()
    {
        SceneManager.LoadScene("Bed", LoadSceneMode.Additive);
    }

    public void BedYes()
    {
        day -= 1;
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

    private void UpdateMoneyText()
    {
        // DataManager 인스턴스가 존재하는지 확인
        if (DataManager.Instance != null)
        {
            money = DataManager.Instance.Money;  // DataManager에서 돈 값 가져오기
            _MoneyText.text = string.Format("{0}", money);  // 돈 텍스트 업데이트
        }
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
