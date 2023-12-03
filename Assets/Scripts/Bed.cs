using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bed : MonoBehaviour
{
    int day;
    int money;

    // UI Text 필드 추가
    [SerializeField]
    private TextMeshProUGUI _MoneyText;

    [SerializeField]
    private TextMeshProUGUI _DayText;

    void Start()
    {
        // 돈 텍스트 업데이트
        UpdateMoneyText();
        UpdateDayText();

        // 날짜가 0이면 엔딩 씬 호출
        if (day == 0)
        {
            EndingScene();
        }
    }

    public void LoadBed()
    {
        // "Bed" 씬을 추가 모드로 로드합니다.
        SceneManager.LoadScene("Bed", LoadSceneMode.Additive);
    }

    public void BedYes()
    {
        // DayCount를 호출하여 날짜 값을 감소시킵니다.
        DataManager.Instance.DayCount();

        // DayCount 호출 후 날짜 텍스트를 업데이트합니다.
        UpdateDayText();
    }

    private void UpdateMoneyText()
    {
        // DataManager 인스턴스가 존재하는지 확인
        if (DataManager.Instance != null)
        {
            // DataManager에서 돈 값 가져오기
            money = DataManager.Instance.Money;
            // 돈 텍스트 업데이트
            _MoneyText.text = string.Format("{0}", money);
        }
    }

    private void UpdateDayText()
    {
        // DataManager 인스턴스가 존재하는지 확인
        if (DataManager.Instance != null)
        {
            // DataManager에서 날짜 값 가져오기
            day = DataManager.Instance.Day;
            if(day==0){
                EndingScene();
            }
            // 날짜 텍스트 업데이트
            _DayText.text = string.Format("{0}", day);
        }
    }

    private void EndingScene()
    {
        // day가 0이 되었을 때
        if (day == 0)
        {
            // 현재 money가 3000 이상이면 Ending1로 이동
            if (money >= 3000)
            {
                SceneManager.LoadScene("Ending1");
            }
            // 현재 money가 3000 미만이면 Ending3로 이동
            else
            {
                SceneManager.LoadScene("Ending3");
            }
        }
    }
}
