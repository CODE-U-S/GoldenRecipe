using UnityEngine;
using EasyUI.Toast;
using UnityEngine.SceneManagement;
public class DataManager : MonoBehaviour
{
    private static DataManager instance;

    public static DataManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<DataManager>();

                if (instance == null)
                {
                    GameObject obj = new GameObject("DataManager");
                    instance = obj.AddComponent<DataManager>();
                }
            }
            return instance;
        }
    }

    private int day = 30;
    private int money = 100;
    private int waterCount = 0;
    private int garlicCount = 0;
    private int potatoCount = 0;
    private int riceCount = 0;
    private int carrotCount = 0;
    private int curryPowderCount = 0;

    public int Day
    {
        get { return day; }
        set { day = value; }
    }

    public void DayCount()
    {
        day--;
        if (day < 0)
        {
            day = 0;
        }
    }

    public int Money
    {
        get { return money; }
        set { money = value; }
    }

    public int WaterCount
    {
        get { return waterCount; }
        set { waterCount = value; }
    }

    public int GarlicCount
    {
        get { return garlicCount; }
        set { garlicCount = value; }
    }

    public int PotatoCount
    {
        get { return potatoCount; }
        set { potatoCount = value; }
    }

    public int RiceCount
    {
        get { return riceCount; }
        set { riceCount = value; }
    }

    public int CarrotCount
    {
        get { return carrotCount; }
        set { carrotCount = value; }
    }

    public int CurryPowderCount
    {
        get { return curryPowderCount; }
        set { curryPowderCount = value; }
    }

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // 각 아이템의 수를 반환하는 메서드 추가
    public int GetItemCount(ItemType itemType)
    {
        switch (itemType)
        {
            case ItemType.Water:
                return WaterCount;
            case ItemType.Garlic:
                return GarlicCount;
            case ItemType.Potato:
                return PotatoCount;
            case ItemType.Rice:
                return RiceCount;
            case ItemType.Carrot:
                return CarrotCount;
            case ItemType.CurryPowder:
                return CurryPowderCount;
            default:
                return 0;
        }
    }

    // 데이터 리셋
    public void ResetGameData()
    {
        money = 100;
        waterCount = 0;
        garlicCount = 0;
        potatoCount = 0;
        riceCount = 0;
        carrotCount = 0;
        curryPowderCount = 0;
        
    }
    public void sleep(){
        SceneManager.LoadScene("Setting");
    }
    
    public void LoadSetting_reset(){
        Toast.Show("초기화 되었습니다.", 2f, new Color(8f, 0.7f, 0.0f));
        SceneManager.LoadScene("Setting", LoadSceneMode.Additive);
        Invoke("sleep", 3);
    }

    private void UpdateMoneyBar()
    {
        // Add code to update the UI for money here
    }

    private void UpdateItemCount()
    {
        // Add code to update the UI for item counts here
    }
}
