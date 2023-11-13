using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class board : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite board_carrot;
    public Sprite board_garlic;
    public Sprite board_potato;
    public Sprite board_leek;

    private Dictionary<string, Sprite> tagToSprite;
    private AudioSource CollisionSound;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        CollisionSound = GetComponent<AudioSource>();

        // 딕셔너리 초기화
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
        // 충돌한 오브젝트의 태그를 가져오기
        string collidedTag = collision.tag;

        // 딕셔너리에서 태그에 해당하는 이미지 가져오기
        if (tagToSprite.ContainsKey(collidedTag))
        {
            Sprite newSprite = tagToSprite[collidedTag];

            CollisionSound.Play();

            // 이미지 변경
            spriteRenderer.sprite = newSprite;
        }
    }
}
