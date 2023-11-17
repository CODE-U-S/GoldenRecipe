using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Image를 사용하기 위해 추가

public class pot : MonoBehaviour
{
    private Image image; // SpriteRenderer 대신 Image로 변경
    private AudioSource audioSource; // AudioSource 추가

    public Sprite pot_carrotpotato;
    public Sprite pot_curry;
    public Sprite pot_leekwater;
    public Sprite pot_potatoleekcarrot;
    public Sprite pot_water;
    public Sprite pot_watercarrot;
    public Sprite pot_waterpotato;

    private Dictionary<string, Sprite> tagToSprite;
    public AudioClip collisionSound; // 직접 추가한 오디오 클립

    void Start()
    {
        image = GetComponent<Image>(); // Image로 변경
        audioSource = gameObject.AddComponent<AudioSource>(); // AudioSource 추가

        // 딕셔너리 초기화
        tagToSprite = new Dictionary<string, Sprite>
        {
            { "water", pot_water },
            { "carrot", pot_watercarrot },
            { "leek", pot_leekwater },
            { "potato", pot_waterpotato },
            { "curry", pot_curry }
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
             if (collidedTag == "curry" && image.sprite == pot_potatoleekcarrot)
            {
                image.sprite = pot_curry;
            }
            else if(collidedTag == "leek" && image.sprite == pot_carrotpotato){

                image.sprite = pot_potatoleekcarrot;
            }
            else if(collidedTag == "carrot" && image.sprite == pot_waterpotato){

                image.sprite = pot_carrotpotato;
            }
            else if(collidedTag == "potato" && image.sprite == pot_watercarrot){

                image.sprite = pot_carrotpotato;
            }
            else
            {
                image.sprite = newSprite;
            }

            // 직접 추가한 오디오 클립을 재생
            if (collisionSound != null)
            {
                audioSource.PlayOneShot(collisionSound); // PlayClipAtPoint 대신 PlayOneShot 사용
            }
            else
            {
                Debug.LogWarning("pot 사운드 없음");
            }
        }
    }
}
