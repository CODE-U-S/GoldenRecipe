using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class board : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite board_carrot; // 바꿀 이미지

    void Start()
    {
       // Start에서 SpriteRenderer 컴포넌트 가져오기
       spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("carrot"))
        {
            // 충돌한 오브젝트의 태그가 "carrot"일 때 이미지 변경
            spriteRenderer.sprite = board_carrot;
        }
    }
}
