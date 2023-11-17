using EasyUI.Toast;
using check.Check;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public Sprite[] sprites;
    public TextMeshProUGUI[] text_money;
    public TextMeshProUGUI[] text_name;
    public TextMeshProUGUI money_bar;

    public Image[] food_image;
    public Button button_random;

    int[] index = new int[6];
    int[] sale_money = new int[3] { 30, 300, 120 };
    int money = 0;
    int[] sale = new int[6];
    int save_check = 0;

    private void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        save_check = PlayerPrefs.GetInt("SavedSave_check");
        if (save_check == 1)
        {
            for(int i = 0; i < 6; i++)
            {
                index[i] = PlayerPrefs.GetInt("SavedIndex" + i); // 저장된 데이터 불러오기
                PrintImage();   //저장된 데이터 프린트하기
            }
        }
        money_bar.text = string.Format("{0}", money);
        //text1, 2, image 불투명
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
            text_money[i].text = sale_money[index[i]].ToString() + "원";
            text_name[i].text = sprites[index[i]].name;
            Debug.Log(sale_money[index[0]]);
            switch (i)
            {
                case 0: sale[i] += sale_money[index[i]]; break;
                case 1: sale[i] += sale_money[index[i]]; break;
                case 2: sale[i] += sale_money[index[i]]; break;
                case 3: sale[i] += sale_money[index[i]]; break;
                case 4: sale[i] += sale_money[index[i]]; break;
                case 5: sale[i] += sale_money[index[i]]; break;
            }
        }
        save_check = 1;
        SaveData();
    }
    private void PrintImage()
    {
        for (int i = 0; i < 6; i++)
        {
            food_image[i].sprite = sprites[index[i]];
            text_money[i].text = sale_money[index[i]].ToString() + "원";
            text_name[i].text = sprites[index[i]].name;
        }
    }
    public void SaleButton1()
    {
        money = PlayerPrefs.GetInt("Money");
        money += sale[0];
        PlayerPrefs.SetInt("Money", money);     //돈 갱신
        money_bar.text = string.Format("{0}", money);
        //GOTO : text1, 2 투명
        //GOTO : image 투명
        //GOTO : 돈 증가
        //GOTO : button image -> 판매완료
        Debug.Log(sale[0] + "원");
        SaveData();
    }
    public void SaleButton2()
    {
        money = PlayerPrefs.GetInt("Money");
        money += sale[1];
        PlayerPrefs.SetInt("Money", money);
        money_bar.text = string.Format("{0}", money);
        SaveData();
    }
    public void SaleButton3()
    {
        money = PlayerPrefs.GetInt("Money");
        money += sale[2];
        PlayerPrefs.SetInt("Money", money);
        money_bar.text = string.Format("{0}", money);
        SaveData();
    }
    public void SaleButton4()
    {
        money = PlayerPrefs.GetInt("Money");
        money += sale[3];
        PlayerPrefs.SetInt("Money", money);
        money_bar.text = string.Format("{0}", money);
        SaveData();
    }
    public void SaleButton5()
    {
        money = PlayerPrefs.GetInt("Money");
        money += sale[4];
        PlayerPrefs.SetInt("Money", money);
        money_bar.text = string.Format("{0}", money);
        SaveData();
    }
    public void SaleButton6()
    {
        money = PlayerPrefs.GetInt("Money");
        money += sale[5];
        PlayerPrefs.SetInt("Money", money);
        money_bar.text = string.Format("{0}", money);
        SaveData();
    }
    private void SaveData()
    {
        for (int i = 0; i < 6; i++)
        {
            PlayerPrefs.SetInt("SavedIndex" + i, index[i]);
        }
        PlayerPrefs.SetInt("SavedSave_check", save_check);
        PlayerPrefs.Save(); // 변경된 PlayerPrefs를 저장합니다.
    }
}