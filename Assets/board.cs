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
    public Sprite Init;

    private Dictionary<string, Sprite> tagToSprite;
    private AudioSource audioSource;

    public AudioClip collisionSound;

    void Start()
    {
        image = GetComponent<Image>();
        audioSource = gameObject.AddComponent<AudioSource>();

        tagToSprite = new Dictionary<string, Sprite>
        {
            { "carrot", boardCarrot },
            { "garlic", boardGarlic },
            { "potato", boardPotato },
            { "leek", boardLeek },
            { "init", Init }
        };

        // GameObject에 Button 컴포넌트가 있는지 확인
        var button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(OnClick);
        }
        else
        {
            Debug.LogWarning("이 GameObject에는 Button 컴포넌트가 없습니다.");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string collidedTag = collision.tag;

        if (tagToSprite.ContainsKey(collidedTag))
        {
            Sprite newSprite = tagToSprite[collidedTag];
            image.sprite = newSprite;

            if (collisionSound != null)
            {
                audioSource.PlayOneShot(collisionSound);
            }
            else
            {
                Debug.LogWarning("Board 사운드 없음");
            }
        }
    }

    public void OnClick()
    {
        image.sprite = Init;
    }
}
