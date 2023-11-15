using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using EasyUI.Toast;

public class RandomTextGenerator : MonoBehaviour
{
    public TextMeshProUGUI randomText; // Unity Inspector에서 텍스트 UI 요소를 연결해주세요.
    public string[] randomTextOptions = new string[5]{
        "\"누룽이표 당근주스\"", "\"개발자 레시피\"", "\"아이템 채소모음\"", "\"하늘색 후라이팬\"", "\"요리사 누룽이\""
    }; // 여러 랜덤 텍스트 옵션들을 배열에 저장합니다.
    bool tiket = false;
    string selectedText = "개발 이스터에그";

    void Start()
    {
        if (tiket)
        {
            Toast.Show("초기화 되었습니다.", 2f, new Color(8f, 0.7f, 0.0f));
            tiket = false;
        }
        GenerateRandomText();
    }

    // 랜덤한 텍스트를 생성하는 메소드
    void GenerateRandomText()
    {
        if (randomText != null && randomTextOptions.Length > 0)
        {
            // 배열에서 랜덤한 텍스트를 선택
            int randomIndex = Random.Range(0, randomTextOptions.Length);

            switch (randomIndex)
            {
                case 0:
                    selectedText = "누룽이표 당근주스";
                    Debug.Log(0);
                    break;
                case 1:
                    selectedText = "개발자 레시피";
                    Debug.Log(1);
                    break;
                case 2:
                    selectedText = "아이템 채소모음";
                    Debug.Log(2);
                    break;
                case 3:
                    selectedText = "하늘색 후라이팬";
                    Debug.Log(3);
                    break;
                case 4:
                    selectedText = "요리사 누룽이";
                    Debug.Log(4);
                    break;
            }

            // 텍스트 UI에 할당
            randomText.text = selectedText;
        }
        else
        {
            Debug.LogWarning("문제발생");
        }
    }
    public void LoadSetting()
    {
        SceneManager.LoadScene("Setting", LoadSceneMode.Additive);
        if(selectedText != null) ysebutton();
    }
    public void ysebutton()
    {
        tiket = true;
        Start();
    }
}
