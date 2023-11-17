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
        LoadSavedData(); // ����� ������ �ҷ�����
        UpdateDaysText(); // �ؽ�Ʈ ������Ʈ
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
        Debug.Log("����Ʈ ��");
        SaveData(); // ������ ����
        SceneManager.LoadScene("Home");
    }

    private void LoadSavedData()
    {
        day = PlayerPrefs.GetInt("SavedDay", 30); // ����� ������ �ҷ�����, �⺻ ���� 30
        money = PlayerPrefs.GetInt("Money");
        Debug.Log(money);
    }

    private void SaveData()
    {
        PlayerPrefs.Save(); // ����� PlayerPrefs�� �����մϴ�.
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
