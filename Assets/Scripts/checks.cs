using UnityEngine.UI;
using UnityEngine;
using TMPro;

namespace check.Check
{
    public class checks : MonoBehaviour
    {
        private void Start()
        {
            OpenandClose.text = "Close";
            check_ = PlayerPrefs.GetInt("SavedCheck");
            check();
        }
        int check_ = 1;
        public TextMeshProUGUI OpenandClose;
        public void check()
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
            PlayerPrefs.Save();
        }
    }
    

}