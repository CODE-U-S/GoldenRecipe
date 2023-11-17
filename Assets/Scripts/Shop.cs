using EasyUI.Toast;
using check.Check;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public Sprite[] sprites;
    public Sprite close;
    public TextMeshProUGUI[] text_money;
    public TextMeshProUGUI[] text_name;

    public Image[] food_image;
    public Button button_random;
    int[] money = new int[3] { 30, 300, 120 };
    bool[] sale = new bool[6];
    private void Start()
    {
        //text1, 2, image 불투명
    }
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
            food_image[i].sprite = select;
            text_money[i].text = money[index].ToString() + "원";
            text_name[i].text = sprites[index].name;
        }
    }
    public void SaleButton()
    {
        //GOTO : text1, 2 투명
        //GOTO : image 투명
        //GOTO : 돈 증가
        //GOTO : button image -> 판매완료
    }
}