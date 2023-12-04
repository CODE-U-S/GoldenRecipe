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
    public TextMeshProUGUI randomButtonText;
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

    public TextMeshProUGUI text_carrotJuiceCount;
    public TextMeshProUGUI text_tomatoJuiceCount;
    public TextMeshProUGUI text_tomatoEggStirFryCount;
    public TextMeshProUGUI text_shrimpFriedRiceCount;
    public TextMeshProUGUI text_curryCount;
    public TextMeshProUGUI text_potatoSoupCount;

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
        UpdateItemCounts(); // 아이템 수 업데이트
    }
    private void UpdateItemCounts()
    {
        text_carrotJuiceCount.text = DataManager.Instance.GetFoodItemCount(FoodItemType.CarrotJuice).ToString();
        text_tomatoJuiceCount.text = DataManager.Instance.GetFoodItemCount(FoodItemType.TomatoJuice).ToString();
        text_tomatoEggStirFryCount.text = DataManager.Instance.GetFoodItemCount(FoodItemType.TomatoEggStirFry).ToString();
        text_shrimpFriedRiceCount.text = DataManager.Instance.GetFoodItemCount(FoodItemType.ShrimpFriedRice).ToString();
        text_curryCount.text = DataManager.Instance.GetFoodItemCount(FoodItemType.Curry).ToString();
        text_potatoSoupCount.text = DataManager.Instance.GetFoodItemCount(FoodItemType.PotatoSoup).ToString();
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
            Debug.Log(sale_money[index[i]]);
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
        UpdateItemCounts(); // 랜덤 이미지를 갱신했을 때 아이템 수 업데이트
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
        if (close_check[0])
        {
            Debug.Log("제대로 작동됨.");
        }
        else
        {
            money += sale_money[index[0]]; // sale_money[0]로 수정
            sale[0] += sale_money[index[0]]; // sale[0]도 갱신
            PlayerPrefs.SetInt("Money", money); // 돈 갱신
            money_bar.text = money.ToString(); // UI에 표시
            Debug.Log(sale[0] + "원");
            Debug.Log(money);
            close_image[0].SetActive(true);
            close_check[0] = true;
            CheckingTheClose();
        }
    }

    public void SaleButton2()
    {
        if (close_check[1])
        {
            Debug.Log("제대로 작동됨.");
        }
        else
        {
            money += sale_money[index[1]]; // sale_money[0]로 수정
            sale[1] += sale_money[index[1]]; // sale[0]도 갱신
            PlayerPrefs.SetInt("Money", money); // 돈 갱신
            money_bar.text = money.ToString(); // UI에 표시
            Debug.Log(sale[1] + "원");
            Debug.Log(money);
            close_image[1].SetActive(true);
            close_check[1] = true;
            CheckingTheClose();
        }
    }
    public void SaleButton3()
    {
        if (close_check[2])
        {
            Debug.Log("제대로 작동됨.");
        }
        else
        {
            money += sale_money[index[2]]; // sale_money[0]로 수정
            sale[2] += sale_money[index[2]]; // sale[0]도 갱신
            PlayerPrefs.SetInt("Money", money); // 돈 갱신
            money_bar.text = money.ToString(); // UI에 표시
            Debug.Log(sale[2] + "원");
            Debug.Log(money);
            close_image[2].SetActive(true);
            close_check[2] = true;
            CheckingTheClose();
        }
    }
    public void SaleButton4()
    {
        if (close_check[3])
        {
            Debug.Log("제대로 작동됨.");
        }
        else
        {
            money += sale_money[index[3]]; // sale_money[0]로 수정
            sale[3] += sale_money[index[3]]; // sale[0]도 갱신
            PlayerPrefs.SetInt("Money", money); // 돈 갱신
            money_bar.text = money.ToString(); // UI에 표시
            Debug.Log(sale[3] + "원");
            Debug.Log(money);
            close_image[3].SetActive(true);
            close_check[3] = true;
            CheckingTheClose();
        }
    }
    public void SaleButton5()
    {
        if (close_check[4])
        {
            Debug.Log("제대로 작동됨.");
        }
        else
        {
            money += sale_money[index[4]]; // sale_money[0]로 수정
            sale[4] += sale_money[index[4]]; // sale[0]도 갱신
            PlayerPrefs.SetInt("Money", money); // 돈 갱신
            money_bar.text = money.ToString(); // UI에 표시
            Debug.Log(sale[4] + "원");
            Debug.Log(money);
            close_image[4].SetActive(true);
            close_check[4] = true;
            CheckingTheClose();
        }
    }
    public void SaleButton6()
    {
        if (close_check[5])
        {
            Debug.Log("제대로 작동됨.");
        }
        else
        {
            money += sale_money[index[5]]; // sale_money[0]로 수정
            sale[5] += sale_money[index[5]]; // sale[0]도 갱신
            PlayerPrefs.SetInt("Money", money); // 돈 갱신
            money_bar.text = money.ToString(); // UI에 표시
            Debug.Log(sale[5] + "원");
            Debug.Log(money);
            close_image[5].SetActive(true);
            close_check[5] = true;
            CheckingTheClose();
        }
    }
    public void CheckingTheClose()
    {
        closeing += 1;
        // closeing이 6 이상이면 버튼 텍스트를 'close'로 변경
        if (closeing >= 6)
        {
            randomButtonText.text = "Close";
        }
        
        SaveData(); // closeing 갱신 후에 호출
    }

    private void SaveData()
    {
        PlayerPrefs.SetInt("SavedSave_check", save_check);
        PlayerPrefs.SetInt("SavedShop_close", closeing);

        for (int i = 0; i < 6; i++)
        {
            PlayerPrefs.SetInt("SavedIndex" + i, index[i]);
        }

        PlayerPrefs.Save(); // 변경된 PlayerPrefs를 저장합니다.
    }

}