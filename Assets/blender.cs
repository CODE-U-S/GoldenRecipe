using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Image를 사용하기 위해 추가

public class blender : MonoBehaviour
{
    private Image image; // SpriteRenderer 대신 Image로 변경
    private AudioSource audioSource; // AudioSource 추가

    public Sprite blender_carrot;
    public Sprite blender_carrotjuice;
    public Sprite blender_water;
    public Sprite blender_watercarrot;

    private Dictionary<string, Sprite> tagToSprite;
    public AudioClip collisionSound; // 직접 추가한 오디오 클립

    void Start()
    {
        image = GetComponent<Image>(); // Image로 변경
        audioSource = gameObject.AddComponent<AudioSource>(); // AudioSource 추가
    
        // 딕셔너리 초기화
        tagToSprite = new Dictionary<string, Sprite>
        {
            { "carrot", blender_carrot },
            { "water", blender_water }
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
                Debug.LogWarning("blender 사운드 없음");
            }
        }
    }
}
