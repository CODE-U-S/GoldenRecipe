using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Image를 사용하기 위해 추가

public class blender : MonoBehaviour
{
    private Image image; // SpriteRenderer 대신 Image로 변경
    private Sprite originalSprite;
    private AudioSource audioSource; // AudioSource 추가

    public Sprite blender_carrot;
    public Sprite blender_carrotjuice;
    public Sprite blender_water;
    public Sprite blender_watercarrot;
    public Sprite Init;

    private Dictionary<string, Sprite> tagToSprite;
    public AudioClip collisionSound; // 직접 추가한 오디오 클립

    void Start()
    {
        image = GetComponent<Image>(); // Image로 변경
        originalSprite = image.sprite;
        audioSource = gameObject.AddComponent<AudioSource>(); // AudioSource 추가
    
        // 딕셔너리 초기화
        tagToSprite = new Dictionary<string, Sprite>
        {
            { "carrot", blender_carrot },
            { "water", blender_water },
            { "init", Init }
        };
    }

    void Update()
    {
        // 마우스 왼쪽 버튼 클릭 감지
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스 포인터의 위치에서 Ray를 쏴서 충돌 감지
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            // 충돌한 객체가 현재 객체인지 확인하고 Sprite를 초기 이미지로 변경
            if (hit.collider != null && hit.collider.gameObject == gameObject)
            {
                image.sprite = originalSprite;
            }
        }
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
            if (collidedTag == "carrot" && image.sprite == blender_water)
            {
                // If the blender is in a water state and a carrot collides, change to blender_carrotjuice
                image.sprite = blender_carrotjuice;
            }
            else if(collidedTag == "water" && image.sprite == blender_carrot){

                image.sprite = blender_carrotjuice;
            }
            else
            {
                // Otherwise, change the image to the new sprite
                image.sprite = newSprite;
            }

            

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
    public void OnClick()
    {
        if (image.sprite == blender_carrotjuice)
        {
            DataManager.Instance.IncreaseFoodItemCount(FoodItemType.CarrotJuice);
        }

        image.sprite = Init;
    }
}