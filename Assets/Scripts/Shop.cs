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
    public GameObject[] close_image;
    public Button button_random;

    int[] index = new int[6];
    int[] sale_money = new int[6] { 100, 30, 350, 500, 350, 30 };
    int money = 0;
    int[] sale = new int[6];
    int save_check = 0;
    bool[] close_check = new bool[6];
    int closeing = 0;
    private void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        money_bar.text = string.Format("{0}", money);
        save_check = PlayerPrefs.GetInt("SavedSave_check");
        if (save_check == 1)
        {
            for(int i = 0; i < 6; i++)
            {
                index[i] = PlayerPrefs.GetInt("SavedIndex" + i);
                // 저장된 데이터 불러오기
                PrintImage();   //저장된 데이터 프린트하기
            }
        }
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
        if(close_check[0]){
            Debug.Log("제대로 작동됨.");
        } else {
            money = PlayerPrefs.GetInt("Money");
            money += sale[0];
            PlayerPrefs.SetInt("Money", money);     //돈 갱신
            money_bar.text = string.Format("{0}", money);
            Debug.Log(sale[0] + "원");
            close_image[0].SetActive(true);
            close_check[0] = true;
            CheckingTheClose();
        }
    }
    public void SaleButton2()
    {
        if(close_check[1]){
            Debug.Log("제대로작동됨.2");
        } else {
            money = PlayerPrefs.GetInt("Money");
            money += sale[1];
            PlayerPrefs.SetInt("Money", money);
            money_bar.text = string.Format("{0}", money);
            close_image[1].SetActive(true);
            close_check[1] = true;
            CheckingTheClose();
        }
    }
    public void SaleButton3()
    {
        if(close_check[2]){
            Debug.Log("제대로작동됨.2");
        } else {
            money = PlayerPrefs.GetInt("Money");
            money += sale[2];
            PlayerPrefs.SetInt("Money", money);
            money_bar.text = string.Format("{0}", money);
            close_image[2].SetActive(true);
            close_check[2] = true;
            CheckingTheClose();
        }
    }
    public void SaleButton4()
    {
        if(close_check[3]){
            Debug.Log("제대로작동됨.2");
        } else {
            money = PlayerPrefs.GetInt("Money");
            money += sale[3];
            PlayerPrefs.SetInt("Money", money);
            money_bar.text = string.Format("{0}", money);
            close_image[3].SetActive(true);
            close_check[3] = true;
            CheckingTheClose();
        }
    }
    public void SaleButton5()
    {
        if(close_check[4]){
            Debug.Log("제대로작동됨.2");
        } else {
            money = PlayerPrefs.GetInt("Money");
            money += sale[4];
            PlayerPrefs.SetInt("Money", money);
            money_bar.text = string.Format("{0}", money);
            close_image[4].SetActive(true);
            close_check[4] = true;
            CheckingTheClose();
        }
    }
    public void SaleButton6()
    {
        if(close_check[5]){
            Debug.Log("제대로작동됨.2");
        } else {
            money = PlayerPrefs.GetInt("Money");
            money += sale[5];
            PlayerPrefs.SetInt("Money", money);
            money_bar.text = string.Format("{0}", money);
            close_image[5].SetActive(true);
            close_check[5] = true;
            CheckingTheClose();
        }
    }
    public void CheckingTheClose(){
            closeing += 1;
            SaveData();
    }
    private void SaveData()
    {
        for (int i = 0; i < 6; i++)
        {
            PlayerPrefs.SetInt("SavedIndex" + i, index[i]);
        }
        PlayerPrefs.SetInt("SavedSave_check", save_check);
        PlayerPrefs.SetInt("SavedShop_close", closeing);
        PlayerPrefs.Save(); // 변경된 PlayerPrefs를 저장합니다.
    }
}