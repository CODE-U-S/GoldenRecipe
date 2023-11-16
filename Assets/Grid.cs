using UnityEngine;
using UnityEngine.UI;

public class ScrollViewController : MonoBehaviour
{
    public GameObject imagePrefab; // UI 이미지 프리팹을 연결합니다.
    public Transform contentTransform; // 스크롤뷰의 Content Transform을 연결합니다.

    public int numberOfImages = 10; // 표시할 이미지 개수를 설정합니다.

    void Start()
    {
        // 이미지를 일정 간격으로 스크롤뷰에 추가합니다.
        for (int i = 0; i < numberOfImages; i++)
        {
            // 이미지를 생성하고 부모를 contentTransform으로 설정합니다.
            GameObject imageObject = Instantiate(imagePrefab, contentTransform);
            
            // 생성된 이미지에 필요한 설정을 추가할 수 있습니다.
            // 예: 이미지의 내용을 동적으로 설정하는 등의 작업을 수행합니다.
        }
    }
}
