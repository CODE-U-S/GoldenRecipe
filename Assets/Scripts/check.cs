
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class check : MonoBehaviour
{
    bool check_ = true;
    public TextMeshProUGUI OpenandClose;
    public void checks()
    {
        if (check_)
        {
            Open();

        }
        else
        {
            Close();
        }
    }

    void Open()
    {
        OpenandClose.text = "Open";
        check_ = false;
    }

    void Close()
    {
        OpenandClose.text = "Close";
        check_ = true;
    }
}
//1. 이미지 오브젝트 배열에 넣기
//2. goods마다 랜덤돌리기(중복 상관x)
//3. 띄우기
//4. 한번 누르면 이미지 사라지기
//5. 다 판매하면 창 띄우기(모두 판매 -> open에서 close로 바꾸라하세요")
