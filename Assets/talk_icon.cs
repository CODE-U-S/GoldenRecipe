using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkIcon : MonoBehaviour
{
    public Sprite[] talkSprites; // 인스펙터에서 직접 이미지 할당

    private Image talkImage; // 이미지를 표시할 Image 컴포넌트

    private int currentIndex = 0; // 현재 이미지의 인덱스
    private float timer = 0f; // 타이머

    public float changeInterval = 5f; // 이미지 변경 간격

    void Start()
    {
        talkImage = GetComponent<Image>();
        if (talkImage == null)
        {
            Debug.LogError("Image component not found on the GameObject.");
            return;
        }

        if (talkSprites.Length == 0)
        {
            Debug.LogError("No sprites assigned to talkSprites array.");
            return;
        }

        // 초기 이미지 설정
        talkImage.sprite = talkSprites[currentIndex];
    }

    void Update()
    {
        // 타이머 업데이트
        timer += Time.deltaTime;

        // 일정 간격마다 이미지 변경
        if (timer >= changeInterval)
        {
            // 다음 이미지로 변경
            currentIndex = (currentIndex + 1) % talkSprites.Length;

            // 이미지 업데이트
            talkImage.sprite = talkSprites[currentIndex];

            // 타이머 초기화
            timer = 0f;
        }
    }
}
