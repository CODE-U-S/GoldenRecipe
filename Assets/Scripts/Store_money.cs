using UnityEngine;
using TMPro;

public class Store_money : MonoBehaviour
{
    public TextMeshProUGUI moneyBarText; // TextMeshProUGUI로 변경
    private int money = 100;

    void Start()
    {
        UpdateMoneyBar();
    }

    void UpdateMoneyBar()
    {
        moneyBarText.text = "Money: " + money;
    }

    // 아이템을 구매하는 함수
    void BuyItem(int cost)
    {
        if (money >= cost)
        {
            money -= cost;
            UpdateMoneyBar();
        }
        else
        {
            Debug.Log("Not enough money to buy this item!");
        }
    }

    // 물을 구매하는 함수
    public void BuyWater()
    {
        BuyItem(5);
    }

    // 마늘을 구매하는 함수
    public void BuyGarlic()
    {
        BuyItem(5);
    }

    // 감자를 구매하는 함수
    public void BuyPotato()
    {
        BuyItem(10);
    }

    // 당근을 구매하는 함수
    public void BuyCarrot()
    {
        BuyItem(10);
    }

    // 밥를 구매하는 함수
    public void BuyRice()
    {
        BuyItem(10);
    }

    // 카레 가루를 구매하는 함수
    public void BuyCurryPowder()
    {
        BuyItem(15);
    }

}
