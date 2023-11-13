using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class food : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;

    private void OnMouseDown()
    {
        // 마우스 클릭 시 현재 위치와 마우스 위치 사이의 오프셋을 계산하여 저장
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isDragging = true;
    }

    private void OnMouseUp()
    {
        // 마우스를 뗄 때 드래깅 상태를 해제
        isDragging = false;
    }

    private void Update()
    {
        if (isDragging)
        {
            // 드래깅 중일 때, 새로운 위치 계산 및 설정
            Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = new Vector3(newPosition.x, newPosition.y, transform.position.z);
        }
    }

    // 트리거 충돌이 발생했을 때 호출되는 메서드
    private void OnTriggerEnter2D(Collider2D other)
    {
        // 충돌한 오브젝트의 태그가 "cooking"이면
        if (other.CompareTag("cooking"))
        {
            // 현재 오브젝트를 파괴 (사라지게 함)
            Destroy(gameObject);
        }
    }
}