using UnityEngine;

public class ClickHandler : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Sprite originalSprite;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        originalSprite = spriteRenderer.sprite;
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
                spriteRenderer.sprite = originalSprite;
            }
        }
    }
}
