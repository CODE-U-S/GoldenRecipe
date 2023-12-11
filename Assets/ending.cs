using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class ending : MonoBehaviour
{
    // VideoPlayer 컴포넌트를 Inspector에서 할당할 변수
    public VideoPlayer videoPlayer;

    // 게임 시작 시 호출되는 메서드
    void Start()
    {
        // videoPlayer가 null이 아닌 경우에만 이벤트에 등록
        if (videoPlayer != null)
        {
            // loopPointReached 이벤트에 대한 메서드를 연결
            videoPlayer.loopPointReached += OnVideoEnd;
        }
    }

    // 매 프레임마다 호출되는 메서드
    void Update()
    {
        // 추가적인 업데이트 로직이 필요한 경우 여기에 작성
    }

    // 동영상 종료 이벤트를 처리하는 메서드
    void OnVideoEnd(VideoPlayer vp)
    {
        // 동영상이 종료되면 "Home" 씬으로 전환
        SceneManager.LoadScene("Home");
    }
}
