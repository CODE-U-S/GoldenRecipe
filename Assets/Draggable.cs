using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private RectTransform rectTransform; // UI 오브젝트의 RectTransform을 저장할 변수
    private CanvasGroup canvasGroup; // UI 오브젝트의 CanvasGroup을 저장할 변수
    private Canvas canvas;  // UI 오브젝트가 속한 Canvas를 저장할 변수

    private void Awake()
    {
        // 컴포넌트 초기화
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = GetComponentInParent<Canvas>();  // 부모에 있는 Canvas를 가져옴
    }

    // 드래그 시작 시 호출되는 메서드
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false; // 드래그 중에는 Raycast를 차단하여 다른 UI 이벤트가 발생하지 않도록 함
    }

    // 드래그 중 호출되는 메서드
    public void OnDrag(PointerEventData eventData)
    {
        // 드래그한 만큼 UI 오브젝트 이동
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    // 드래그 종료 시 호출되는 메서드
    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true; // 드래그 종료 후 다시 Raycast 활성화

        // 특정 조건 충족 시 처리
        HandleDragEnd();
    }

    // 트리거 충돌이 발생했을 때 호출되는 메서드
    private void OnTriggerEnter2D(Collider2D other)
    {
        // 충돌한 오브젝트의 태그가 "cooking"이면
        if (other.CompareTag("cooking"))
        {
            // 부모 오브젝트와 현재 오브젝트 파괴
            Destroy(transform.parent.gameObject);  // 부모 오브젝트 파괴
            Destroy(gameObject);  // 현재 오브젝트 파괴
        }
    }

    // 드래그 종료 후 처리할 내용을 담당하는 메서드
    private void HandleDragEnd()
    {
        // 드래그 종료 시 추가적인 동작을 구현할 수 있음
        // 여기에 필요한 코드를 추가하세요.
    }
}
