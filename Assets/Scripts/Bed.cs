using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Bed : MonoBehaviour
{
    int day = 30;

    [SerializeField]
    TextMeshProUGUI _DaysText;

    void Start()
    {
        LoadSavedData(); // ����� ������ �ҷ�����
        UpdateDaysText(); // �ؽ�Ʈ ������Ʈ
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
    }

    private void SaveData()
    {
        PlayerPrefs.Save(); // ����� PlayerPrefs�� �����մϴ�.
    }

    private void UpdateDaysText()
    {
        _DaysText.text = string.Format("D-{0:D1}", day);
    }
}
