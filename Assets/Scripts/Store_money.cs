using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Store_money : MonoBehaviour
{
    
    public TextMeshProUGUI moneybar_text; // UI���� ���� ǥ���� Text ������Ʈ�� �������ݴϴ�.
    static int money = 100; // �ʱ� �� ��


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
        Debug.Log("�� �Ӵ�");
        moneybar_text.text = money + " "; // UI ������Ʈ
    }
}