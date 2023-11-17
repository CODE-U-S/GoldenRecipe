using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Canvas canvas;  // canvas 변수 추가

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        canvas = GetComponentInParent<Canvas>();  // 부모에 있는 Canvas를 가져옴
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
    }

    // 트리거 충돌이 발생했을 때 호출되는 메서드
    private void OnTriggerEnter2D(Collider2D other)
    {
        // 충돌한 오브젝트의 태그가 "cooking"이면
        if (other.CompareTag("cooking"))
        {
            // 부모 오브젝트 파괴
            Destroy(transform.parent.gameObject);  // Destroy the parent object
            // 현재 오브젝트 파괴
            Destroy(gameObject);  // Destroy the current object
        }
    }
}
