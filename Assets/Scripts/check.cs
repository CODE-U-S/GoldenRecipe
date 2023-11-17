
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
            check_ = PlayerPrefs.GetInt("SavedCheck"); // ����� ������ �ҷ�����
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
            PlayerPrefs.Save(); // ����� PlayerPrefs�� �����մϴ�.
        }
    }
//1. �̹��� ������Ʈ �迭�� �ֱ� [Ŭ����]
//2. goods���� ����������(�ߺ� ���x) [Ŭ����]
//3. ����    [Ŭ����]
//4. �ѹ� ������ �̹��� �������
//5. �� �Ǹ��ϸ� â ����(��� �Ǹ� -> open���� close�� �ٲٶ��ϼ���")

}