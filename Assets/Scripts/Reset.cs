using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using EasyUI.Toast;

public class RandomTextGenerator : MonoBehaviour
{
    public TextMeshProUGUI randomText; // Unity Inspector���� �ؽ�Ʈ UI ��Ҹ� �������ּ���.
    public string[] randomTextOptions = new string[5]{
        "\"������ǥ ����ֽ�\"", "\"������ ������\"", "\"������ ä�Ҹ���\"", "\"�ϴû� �Ķ�����\"", "\"�丮�� ������\""
    }; // ���� ���� �ؽ�Ʈ �ɼǵ��� �迭�� �����մϴ�.
    bool tiket = false;
    string selectedText = "���� �̽��Ϳ���";

    void Start()
    {
        if (tiket)
        {
            Toast.Show("�ʱ�ȭ �Ǿ����ϴ�.", 2f, new Color(8f, 0.7f, 0.0f));
            tiket = false;
        }
        GenerateRandomText();
    }

    // ������ �ؽ�Ʈ�� �����ϴ� �޼ҵ�
    void GenerateRandomText()
    {
        if (randomText != null && randomTextOptions.Length > 0)
        {
            // �迭���� ������ �ؽ�Ʈ�� ����
            int randomIndex = Random.Range(0, randomTextOptions.Length);

            switch (randomIndex)
            {
                case 0:
                    selectedText = "������ǥ ����ֽ�";
                    Debug.Log(0);
                    break;
                case 1:
                    selectedText = "������ ������";
                    Debug.Log(1);
                    break;
                case 2:
                    selectedText = "������ ä�Ҹ���";
                    Debug.Log(2);
                    break;
                case 3:
                    selectedText = "�ϴû� �Ķ�����";
                    Debug.Log(3);
                    break;
                case 4:
                    selectedText = "�丮�� ������";
                    Debug.Log(4);
                    break;
            }

            // �ؽ�Ʈ UI�� �Ҵ�
            randomText.text = selectedText;
        }
        else
        {
            Debug.LogWarning("�����߻�");
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
