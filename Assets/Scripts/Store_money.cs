using UnityEngine;
using UnityEngine.SceneManagement;
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

    public GameObject waterPrefab;
    public GameObject garlicPrefab;
    public GameObject potatoPrefab;
    public GameObject ricePrefab;
    public GameObject carrotPrefab;
    public GameObject curryPowderPrefab;

    public GameObject content; // content 변수 선언

    private int money = 100;
    private int waterCount = 0;
    private int garlicCount = 0;
    private int potatoCount = 0;
    private int riceCount = 0;
    private int carrotCount = 0;
    private int curryPowderCount = 0;
    private void Awake()
    {
        // 게임 시작 시에 데이터 불러오기
        LoadGameData();
    }
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

    void SaveGameData()
    {
        // PlayerPrefs를 사용하여 데이터 저장
        PlayerPrefs.SetInt("Money", money);
        PlayerPrefs.SetInt("WaterCount", waterCount);
        PlayerPrefs.SetInt("GarlicCount", garlicCount);
        PlayerPrefs.SetInt("PotatoCount", potatoCount);
        PlayerPrefs.SetInt("RiceCount", riceCount);
        PlayerPrefs.SetInt("CarrotCount", carrotCount);
        PlayerPrefs.SetInt("CurryPowderCount", curryPowderCount);
        PlayerPrefs.Save();
    }
    void LoadGameData()
    {
        // PlayerPrefs를 사용하여 데이터 불러오기
        money = PlayerPrefs.GetInt("Money", 100);
        waterCount = PlayerPrefs.GetInt("WaterCount", 0);
        garlicCount = PlayerPrefs.GetInt("GarlicCount", 0);
        potatoCount = PlayerPrefs.GetInt("PotatoCount", 0);
        riceCount = PlayerPrefs.GetInt("RiceCount", 0);
        carrotCount = PlayerPrefs.GetInt("CarrotCount", 0);
        curryPowderCount = PlayerPrefs.GetInt("CurryPowderCount", 0);
    }
    void BuyItem(int cost, GameObject prefab)
    {
        money -= cost;
        UpdateMoneyBar();
        UpdateItemCount();
        SaveGameData(); // 데이터 저장

        // 프리팹을 인스턴스화하고 content(컨테이너)에 추가합니다.
        GameObject newItem = Instantiate(prefab, content.transform);
        // 여기에서 인스턴스화된 객체의 위치 또는 다른 속성을 조절할 수 있습니다.
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
        if(money>=5){
            BuyItem(5, waterPrefab);
            waterCount++;
            UpdateItemCount();
            PlayButtonClickSound(coinSound);
        
        }
    }

    public void BuyGarlic()
    {
        if(money>=5){
            BuyItem(5, garlicPrefab);
            garlicCount++;
            UpdateItemCount();
            PlayButtonClickSound(coinSound);
        }
        
    }

    public void BuyPotato()
    {   
        if(money>=10){
            BuyItem(10, potatoPrefab);
            potatoCount++;
            UpdateItemCount();
            PlayButtonClickSound(coinSound);    
        }   
    }

    public void BuyCarrot()
    {   
        if(money>=10){
            BuyItem(10, carrotPrefab);
            carrotCount++;
            UpdateItemCount();
            PlayButtonClickSound(coinSound);
        }
    }

    public void BuyRice()
    {   
        if(money>=10){
            BuyItem(10, ricePrefab);
            riceCount++;
            UpdateItemCount();
            PlayButtonClickSound(coinSound);
        }
    }
    
    public void BuyCurryPowder()
    {
        if(money>=15){
            BuyItem(15, curryPowderPrefab);
            curryPowderCount++;
            UpdateItemCount();
            PlayButtonClickSound(coinSound);
        }
    }

    public void ResetGameData()
    {
        // PlayerPrefs로 저장된 모든 데이터 초기화
        PlayerPrefs.DeleteAll();
        // 초기값으로 데이터 설정
        money = 100;
        waterCount = 0;
        garlicCount = 0;
        potatoCount = 0;
        riceCount = 0;
        carrotCount = 0;
        curryPowderCount = 0;

        // 초기화된 데이터로 UI 업데이트
        UpdateMoneyBar();
        UpdateItemCount();
    }
}
