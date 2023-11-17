using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    private Image image;
    public Sprite boardCarrot;
    public Sprite boardGarlic;
    public Sprite boardPotato;
    public Sprite boardLeek;

    private Dictionary<string, Sprite> tagToSprite;
    private AudioSource audioSource; // AudioSource 추가

    public AudioClip collisionSound; // 직접 추가한 오디오 클립

    void Start()
    {
        image = GetComponent<Image>();
        audioSource = gameObject.AddComponent<AudioSource>(); // AudioSource 추가

        // 딕셔너리 초기화
        tagToSprite = new Dictionary<string, Sprite>
        {
            { "carrot", boardCarrot },
            { "garlic", boardGarlic },
            { "potato", boardPotato },
            { "leek", boardLeek }
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
            image.sprite = newSprite;

            // 직접 추가한 오디오 클립을 재생
            if (collisionSound != null)
            {
                audioSource.PlayOneShot(collisionSound); // PlayClipAtPoint 대신 PlayOneShot 사용
            }
            else
            {
                Debug.LogWarning("Board 사운드 없음");
            }
        }
    }
}
