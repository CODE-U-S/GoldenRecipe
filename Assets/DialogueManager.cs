using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;  // UI Text 컴포넌트에 대한 참조
    private string[] dialogues = new string[]
    {
        "좋은 아침! 오늘은 어떤 요리로 하루를 시작할까요?",
        "낮에는 가볍고 영양가 있는 음식을 준비하고 싶어. 무슨 아이디어가 있을까요?",
        "이런 햇볕 찬란한 날씨에는 상큼하고 시원한 음식이 어울리겠죠. 레몬 파스타는 어떠세요?",
        "오늘은 친구들을 초대해서 함께 식사하는 날이에요. 특별한 요리 아이디어가 있나요?",
        "이번에 시도해 볼 만한 신규 레시피가 있을까요? 낮에 먹기 좋은 거라면 좋겠어요.",
        "오늘은 어떤 맛을 찾아볼지 기대돼.",
        "오늘은 특별한 날, 그에 어울리는 요리를 찾아보자."
    };

    private int currentDialogueIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        // UI Text 컴포넌트에 대한 참조를 설정
        dialogueText = GameObject.Find("DialogueText").GetComponent<Text>();

        // 스크립트 시작시 첫 번째 대화를 표시
        ShowNextDialogue();
        
        // 10초마다 대화 갱신을 위한 코루틴 시작
        InvokeRepeating("ShowNextDialogue", 10f, 10f);
    }

    // 10초마다 다음 대화를 표시하는 함수
    void ShowNextDialogue()
    {
        // 현재 대화 표시
        dialogueText.text = dialogues[currentDialogueIndex];

        // 다음 대화로 이동 (순환)
        currentDialogueIndex = (currentDialogueIndex + 1) % dialogues.Length;
    }
}
