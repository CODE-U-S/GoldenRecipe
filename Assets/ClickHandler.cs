using UnityEngine;
using UnityEngine.UI;

public class ClickHandler : MonoBehaviour
{
    private Image image;
    private Sprite originalSprite;

    void Start()
    {
        image = GetComponent<Image>();
        originalSprite = image.sprite;
    }

    void Update()
    {
        // 마우스 왼쪽 버튼 클릭 감지
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스 포인터의 위치에서 Ray를 쏴서 충돌 감지
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            // 충돌한 객체가 현재 객체인지 확인하고 Sprite를 초기 이미지로 변경
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                image.sprite = originalSprite;
            }
        }
    }
}
