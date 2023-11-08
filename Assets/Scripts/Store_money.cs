using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Store_money : MonoBehaviour
{
    
    public TextMeshProUGUI moneybar_text; // UI에서 돈을 표시할 Text 컴포넌트를 연결해줍니다.
    static int money = 100; // 초기 돈 값


    public void Subtract5()
    {
        Debug.Log("money 5");
        money -= 5;
        update(money);
    }

    public void Subtract10()
    {
        Debug.Log("money 10");
        money -= 10;
        update(money);
    }

    public void Subtract15()
    {
        Debug.Log("money 15");
        money -= 15;
        update(money);
    }
    public void update(int money)
    {
        Debug.Log("총 머니");
        moneybar_text.text = money + " "; // UI 업데이트
    }
}