
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
//1. �̹��� ������Ʈ �迭�� �ֱ�
//2. goods���� ����������(�ߺ� ���x)
//3. ����
//4. �ѹ� ������ �̹��� �������
//5. �� �Ǹ��ϸ� â ����(��� �Ǹ� -> open���� close�� �ٲٶ��ϼ���")
