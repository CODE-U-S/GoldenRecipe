using UnityEngine;
using TMPro;

public class Store_money : MonoBehaviour
{
    public TextMeshProUGUI moneyBarText;
    public TextMeshProUGUI waterText;
    public TextMeshProUGUI garlicText;
    public TextMeshProUGUI potatoText;
    public TextMeshProUGUI riceText;
    public TextMeshProUGUI carrotText;
    public TextMeshProUGUI curryPowderText;

    private int money = 100;
    private int waterCount = 0;
    private int garlicCount = 0;
    private int potatoCount = 0;
    private int riceCount = 0;
    private int carrotCount = 0;
    private int curryPowderCount = 0;

    void Start()
    {
        UpdateMoneyBar();
        UpdateItemCount();
    }

    void UpdateMoneyBar()
    {
        moneyBarText.text = "Money: " + money;
    }

    void UpdateItemCount()
    {
        waterText.text = "Water: " + waterCount;
        garlicText.text = "Garlic: " + garlicCount;
        potatoText.text = "Potato: " + potatoCount;
        riceText.text = "Rice: " + riceCount;
        carrotText.text = "Carrot: " + carrotCount;
        curryPowderText.text = "Curry Powder: " + curryPowderCount;
    }

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

    public void BuyWater()
    {
        BuyItem(5);
        waterCount++;
        UpdateItemCount();
    }

    public void BuyGarlic()
    {
        BuyItem(5);
        garlicCount++;
        UpdateItemCount();
    }

    public void BuyPotato()
    {
        BuyItem(10);
        potatoCount++;
        UpdateItemCount();
    }

    public void BuyCarrot()
    {
        BuyItem(10);
        carrotCount++;
        UpdateItemCount();
    }

    public void BuyRice()
    {
        BuyItem(10);
        riceCount++;
        UpdateItemCount();
    }
    
    public void BuyCurryPowder()
    {
        BuyItem(15);
        curryPowderCount++;
        UpdateItemCount();
    }
}
