
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public Sprite[] sprites;
    public TextMeshProUGUI[] text_money;
    public TextMeshProUGUI[] text_name;

    public Image[] image;
    public Button button_random;
    int[] money = new int[3] { 30, 300, 120 };
    public void Init_UI()
    {
        button_random.onClick.RemoveAllListeners();
        button_random.onClick.AddListener(Funciton_RandomImage);

    }
    private void Funciton_RandomImage()
    {
        int index;
        for (int i = 0; i < 6; i++)
        {
            index = Random.Range(0, sprites.Length);
            Sprite select = sprites[index];
            image[i].sprite = select;
            text_money[i].text = money[index].ToString() + "¿ø";
            text_name[i].text = sprites[index].name;
        }
    }
}