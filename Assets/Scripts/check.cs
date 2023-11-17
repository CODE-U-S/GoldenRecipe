
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace check.Check
{
    public class check : MonoBehaviour
    {
        private void Start()
        {
            check_ = PlayerPrefs.GetInt("SavedCheck"); // 저장된 데이터 불러오기
            checks();
        }
        int check_ = 1;
        public TextMeshProUGUI OpenandClose;
        public void checks()
        {
            if (check_ == 1)
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
            check_ = 0;
            SaveData();
        }

        void Close()
        {
            OpenandClose.text = "Close";
            check_ = 1;
            SaveData();
        }

        private void SaveData()
        {
            PlayerPrefs.Save(); // 변경된 PlayerPrefs를 저장합니다.
        }
    }
//1. 이미지 오브젝트 배열에 넣기 [클리어]
//2. goods마다 랜덤돌리기(중복 상관x) [클리어]
//3. 띄우기    [클리어]
//4. 한번 누르면 이미지 사라지기
//5. 다 판매하면 창 띄우기(모두 판매 -> open에서 close로 바꾸라하세요")

}