using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pen : MonoBehaviour
{
    private Image image; // SpriteRenderer 대신 Image로 변경
    private AudioSource audioSource; // AudioSource 추가

    public Sprite pen_leek;
    public Sprite pen_leekshrimp;
    public Sprite pen_shrimp;
    public Sprite pen_shrimpfriedrice;
    public Sprite Init;

    private Dictionary<string, Sprite> tagToSprite;
    public AudioClip collisionSound; // 직접 추가한 오디오 클립

    void Start()
    {
        image = GetComponent<Image>();
        audioSource = gameObject.AddComponent<AudioSource>(); // AudioSource 추가

        // 딕셔너리 초기화
        tagToSprite = new Dictionary<string, Sprite>
        {
            { "shrimp", pen_shrimp },
            { "leek", pen_leek },
            { "rice", pen_shrimpfriedrice },
            { "init", Init }
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
            
            if(collidedTag == "rice" && image.sprite == pen_leekshrimp){

                image.sprite = pen_shrimpfriedrice;
            }
            else if (collidedTag == "leek" && image.sprite == pen_shrimp)
            {
                // If the blender is in a water state and a carrot collides, change to blender_carrotjuice
                image.sprite = pen_leekshrimp;
            }
            else if(collidedTag == "shrimp" && image.sprite == pen_leek){

                image.sprite = pen_leekshrimp;
            }
            else
            {
                // Otherwise, change the image to the new sprite
                image.sprite = newSprite;
            }

            // 직접 추가한 오디오 클립을 재생
            if (collisionSound != null)
            {
                audioSource.PlayOneShot(collisionSound, 1f); // PlayClipAtPoint 대신 PlayOneShot 사용
            }
            else
            {
                Debug.LogWarning("pen 사운드 없음");
            }
        }
    }
    public void OnClick()
    {
        if (image.sprite == pen_shrimpfriedrice)
        {
            DataManager.Instance.IncreaseFoodItemCount(FoodItemType.ShrimpFriedRice);
        }
        image.sprite = Init;
    }
}
