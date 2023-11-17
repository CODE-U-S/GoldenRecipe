using EasyUI.Toast;
using check.Check;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Shop : MonoBehaviour
{
    public Sprite[] sprites;
    public TextMeshProUGUI[] text_money;
    public TextMeshProUGUI[] text_name;

    public Image[] food_image;
    public Button button_random;
    int[] index = new int[6];
    int[] money = new int[3] { 30, 300, 120 };
    bool[] sale = new bool[6];
    int save_check = 0;

    private void Start()
    {
        save_check = PlayerPrefs.GetInt("SavedSave_check");
        Debug.Log(save_check);
        if (save_check == 1)
        {
            for(int i = 0; i < 6; i++)
            {
                index[i] = PlayerPrefs.GetInt("SavedIndex" + i); // ����� ������ �ҷ�����
                PrintImage();   //����� ������ ����Ʈ�ϱ�
            }
        }
        //text1, 2, image ������
    }
    public void Init_UI()
    {
        button_random.onClick.AddListener(Funciton_RandomImage);
    }
    private void Funciton_RandomImage()
    {
        for (int i = 0; i < 6; i++)
        {
            index[i] = Random.Range(0, sprites.Length);
            Sprite select = sprites[index[i]];
            food_image[i].sprite = select;
            text_money[i].text = money[index[i]].ToString() + "��";
            text_name[i].text = sprites[index[i]].name;
        }
        save_check = 1;
        SaveData();
    }
    private void PrintImage()
    {
        for (int i = 0; i < 6; i++)
        {
            food_image[i].sprite = sprites[index[i]];
            text_money[i].text = money[index[i]].ToString() + "��";
            text_name[i].text = sprites[index[i]].name;
        }
    }
    public void SaleButton()
    {
        //GOTO : text1, 2 ����
        //GOTO : image ����
        //GOTO : �� ����
        //GOTO : button image -> �ǸſϷ�
    }
    private void SaveData()
    {
        for (int i = 0; i < 6; i++)
        {
            PlayerPrefs.SetInt("SavedIndex" + i, index[i]);
        }
        PlayerPrefs.SetInt("SavedSave_check", save_check);
        PlayerPrefs.Save(); // ����� PlayerPrefs�� �����մϴ�.
    }
}