using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pen : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite pen_leek;
    public Sprite pen_leekshrimp;
    public Sprite pen_shrimp;
    public Sprite pen_shrimpfriedrice;

    private Dictionary<string, Sprite> tagToSprite;
    public AudioClip collisionSound; // 직접 추가한 오디오 클립

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        

        // 딕셔너리 초기화
        tagToSprite = new Dictionary<string, Sprite>
        {
            { "shrimp", pen_shrimp },
            { "leek", pen_leek },
           
        };
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 충돌한 오브젝트의 태그를 가져오기
        string collidedTag = collision.tag;

        // 딕셔너리에서 태그에 해당하는 이미지 가져오기
        if (tagToSprite.ContainsKey(collidedTag))
        {
            Sprite newSprite = tagToSprite[collidedTag];

            // 이미지 변경
            spriteRenderer.sprite = newSprite;

            // 직접 추가한 오디오 클립을 재생
            if (collisionSound != null)
            {
                AudioSource.PlayClipAtPoint(collisionSound, transform.position);
            }
            else
            {
                Debug.LogWarning("pen 사운드 없음");
            }
        }
    }
}
