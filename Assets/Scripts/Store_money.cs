using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Store_money : MonoBehaviour
{
    public TextMeshProUGUI moneyBarText;  // 돈 표시용 UI 텍스트
    public TextMeshProUGUI waterText;     // 물 아이템 표시용 UI 텍스트
    public TextMeshProUGUI garlicText;    // 마늘 아이템 표시용 UI 텍스트
    public TextMeshProUGUI potatoText;    // 감자 아이템 표시용 UI 텍스트
    public TextMeshProUGUI riceText;      // 쌀 아이템 표시용 UI 텍스트
    public TextMeshProUGUI carrotText;    // 당근 아이템 표시용 UI 텍스트
    public TextMeshProUGUI curryPowderText;  // 카레 가루 아이템 표시용 UI 텍스트

    public AudioClip coinSound;  // 코인 효과음 파일

    private void Start()
    {
        UpdateMoneyBar();   // 초기에 돈 표시 업데이트
        UpdateItemCount();  // 초기에 아이템 갯수 표시 업데이트
    }

    // 돈 표시 업데이트
    private void UpdateMoneyBar()
    {
        moneyBarText.text = DataManager.Instance.Money.ToString();
    }

    private void UpdateItemCount()
    {
        waterText.text = DataManager.Instance.WaterCount.ToString();
        garlicText.text = DataManager.Instance.GarlicCount.ToString();
        potatoText.text = DataManager.Instance.PotatoCount.ToString();
        riceText.text =  DataManager.Instance.RiceCount.ToString();
        carrotText.text = DataManager.Instance.CarrotCount.ToString();
        curryPowderText.text = DataManager.Instance.CurryPowderCount.ToString();
    }

    private void SaveGameData()
    {
        PlayerPrefs.SetInt("Money", DataManager.Instance.Money);
        PlayerPrefs.SetInt("WaterCount", DataManager.Instance.WaterCount);
        PlayerPrefs.SetInt("GarlicCount", DataManager.Instance.GarlicCount);
        PlayerPrefs.SetInt("PotatoCount", DataManager.Instance.PotatoCount);
        PlayerPrefs.SetInt("RiceCount", DataManager.Instance.RiceCount);
        PlayerPrefs.SetInt("CarrotCount", DataManager.Instance.CarrotCount);
        PlayerPrefs.SetInt("CurryPowderCount", DataManager.Instance.CurryPowderCount);
        PlayerPrefs.Save();
    }

    private void BuyItem(int cost)
    {
        DataManager.Instance.Money -= cost;
        UpdateMoneyBar();
        UpdateItemCount();
        SaveGameData();
    }

    private void PlayButtonClickSound(AudioClip sound)
    {
        if (sound != null)
        {
            AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);
        }
    }

    // 물 아이템 구매 버튼 클릭 시 호출
    public void BuyWater()
    {
        if (DataManager.Instance.Money >= 5)
        {
            BuyItem(5);  
            DataManager.Instance.WaterCount++;
            UpdateItemCount();
            PlayButtonClickSound(coinSound);
        }
    }

    public void BuyGarlic()
    {
        if (DataManager.Instance.Money >= 5)
        {
            BuyItem(5);
            DataManager.Instance.GarlicCount++;
            UpdateItemCount();
            PlayButtonClickSound(coinSound);
        }
    }

    public void BuyPotato()
    {
        if (DataManager.Instance.Money >= 10)
        {
            BuyItem(10);
            DataManager.Instance.PotatoCount++;
            UpdateItemCount();
            PlayButtonClickSound(coinSound);
        }
    }

    public void BuyCarrot()
    {
        if (DataManager.Instance.Money >= 10)
        {
            BuyItem(10);
            DataManager.Instance.CarrotCount++;
            UpdateItemCount();
            PlayButtonClickSound(coinSound);
        }
    }

    public void BuyRice()
    {
        if (DataManager.Instance.Money >= 10)
        {
            BuyItem(10);
            DataManager.Instance.RiceCount++;
            UpdateItemCount();
            PlayButtonClickSound(coinSound);
        }
    }

    public void BuyCurryPowder()
    {
        if (DataManager.Instance.Money >= 15)
        {
            BuyItem(15);
            DataManager.Instance.CurryPowderCount++;
            UpdateItemCount();
            PlayButtonClickSound(coinSound);
        }
    }


}
