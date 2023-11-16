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

    public AudioClip coinSound;  // 추가: 코인 효과음 파일


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
    private void PlayButtonClickSound(AudioClip sound)
    {
        if (sound != null)
        {
            AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);
            // 주의: 이 방법은 2D 사운드 효과를 제공하며, AudioListener 위치에서 사운드를 재생합니다.
            // 다른 사운드 효과가 필요하면 적절한 AudioSource를 만들어 사용하세요.
        }
    }

    public void BuyWater()
    {
        BuyItem(5);
        waterCount++;
        UpdateItemCount();
        PlayButtonClickSound(coinSound);
    }

    public void BuyGarlic()
    {
        BuyItem(5);
        garlicCount++;
        UpdateItemCount();
        PlayButtonClickSound(coinSound);
    }

    public void BuyPotato()
    {
        BuyItem(10);
        potatoCount++;
        UpdateItemCount();
        PlayButtonClickSound(coinSound);
    }

    public void BuyCarrot()
    {
        BuyItem(10);
        carrotCount++;
        UpdateItemCount();
        PlayButtonClickSound(coinSound);
    }

    public void BuyRice()
    {
        BuyItem(10);
        riceCount++;
        UpdateItemCount();
        PlayButtonClickSound(coinSound);
    }
    
    public void BuyCurryPowder()
    {
        BuyItem(15);
        curryPowderCount++;
        UpdateItemCount();
        PlayButtonClickSound(coinSound);
    }
}
