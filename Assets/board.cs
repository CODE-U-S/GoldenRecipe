using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class board : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Sprite defaultSprite; // 기본 이미지를 저장할 변수 추가
    public Sprite board_carrot;
    public Sprite board_garlic;
    public Sprite board_potato;
    public Sprite board_leek;

    private Dictionary<string, Sprite> tagToSprite;
    public AudioClip collisionSound;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        defaultSprite = spriteRenderer.sprite; // 기본 이미지 설정

        tagToSprite = new Dictionary<string, Sprite>
        {
            { "carrot", board_carrot },
            { "garlic", board_garlic },
            { "potato", board_potato },
            { "leek", board_leek }
        };
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string collidedTag = collision.tag;

        if (tagToSprite.ContainsKey(collidedTag))
        {
            Sprite newSprite = tagToSprite[collidedTag];
            spriteRenderer.sprite = newSprite;

            if (collisionSound != null)
            {
                AudioSource.PlayClipAtPoint(collisionSound, transform.position);
            }
            else
            {
                Debug.LogWarning("board 사운드 없음");
            }
        }
    }

    // 새로운 함수 추가: 기본 이미지로 되돌리기
    public void ResetToDefaultSprite()
    {
        spriteRenderer.sprite = defaultSprite;
    }
}
