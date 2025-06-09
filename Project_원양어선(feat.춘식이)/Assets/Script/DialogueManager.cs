using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    [Header("UI 연결")]
    public TextMeshProUGUI dialogueText;   // 디렉터 대사 출력
    public Button buttonYes;               // 좋아요 버튼
    public Button buttonNo;                // 죽어 버튼
    public TextMeshProUGUI buttonYesText;  // 좋아요 텍스트
    public TextMeshProUGUI buttonNoText;   // 죽어 텍스트

    // 현재 진행 중인 노드
    private DialogueNode currentNode;

    // 대사 노드 정의
    private class DialogueNode
    {
        public string directorLine;         // 디렉터 대사
        public string yesButtonLabel;       // 좋아요 버튼 텍스트
        public string noButtonLabel;        // 싫어요 버튼 텍스트
        public DialogueNode nextYes;        // 좋아요 누를 시 다음
        public DialogueNode nextNo;         // 싫어요 누를 시 다음

        public DialogueNode(string line, string yesLabel, string noLabel)
        {
            directorLine = line;
            yesButtonLabel = yesLabel;
            noButtonLabel = noLabel;
        }
    }

    void Start()
    {
        BuildDialogueTree();  // 전체 대사 흐름 구성

        // 버튼 클릭 이벤트 연결
        buttonYes.onClick.AddListener(OnYesClicked);
        buttonNo.onClick.AddListener(OnNoClicked);

        // 첫 대사 출력
        RefreshUI();
    }

    void OnYesClicked()
    {
        if (currentNode.nextYes != null)
        {
            currentNode = currentNode.nextYes;
            RefreshUI();
        }
    }

    void OnNoClicked()
    {
        if (currentNode.nextNo != null)
        {
            currentNode = currentNode.nextNo;
            RefreshUI();
        }
    }

    // UI에 대사 + 버튼 텍스트 반영
    void RefreshUI()
    {
        dialogueText.text = currentNode.directorLine;
        buttonYesText.text = currentNode.yesButtonLabel ?? "";
        buttonNoText.text = currentNode.noButtonLabel ?? "";

        // 버튼 비활성화 처리
        buttonYes.interactable = currentNode.nextYes != null;
        buttonNo.interactable = currentNode.nextNo != null;
    }

    // 🌱 대사 분기 구조 생성
    void BuildDialogueTree()
    {
        // 말풍선만 출력되는 엔딩 노드들
        var endA = new DialogueNode("그러면 나이스단을 갈아서 식당을 운영하겠습니다. 감사합니다", "", "");
        var endB = new DialogueNode("잘못된 패치로 모든 유저가 떠나고 로아는 서비스를 종료했다.", "", "");
        var endC = new DialogueNode("그렇게 모든 유저가 떠나고 로아는 서비스를 종료했다.", "", "");

        var node_gold = new DialogueNode(
            "모험가님들 진짜 저희가 너무 무능했습니다. 대신에 경제를 잡기 위해서 골두꺼비? 3시간 후부터 바로! 시작하겠습니다.",
            "", "그렇게 모든 유저가 떠나고 로아는 서비스를 종료했다.");
        node_gold.nextNo = endC;

        var node_jinluton = new DialogueNode(
            "헉 정말 죄송합니다.. 사죄의 의미로 전투분석 요거 꼭 넣겠습니다.",
            node_gold.directorLine, endC.directorLine);
        node_jinluton.nextYes = node_gold;
        node_jinluton.nextNo = endC;

        var node_jewel = new DialogueNode(
            "그러면 저희의 실수를 만회하고자 보석 귀속시스템 도입하겠습니다^^",
            endA.directorLine, endB.directorLine);
        node_jewel.nextYes = endA;
        node_jewel.nextNo = endB;

        var node_apologize = new DialogueNode(
            "저희가 너무 오만했던거 같습니다... 죄송합니다.",
            node_jewel.directorLine, node_jinluton.directorLine);
        node_apologize.nextYes = node_jewel;
        node_apologize.nextNo = node_jinluton;

        var node_payment = new DialogueNode(
            "그럼 35,000원 입장료를 지불해주세요 왕자님~",
            "자 어디 믹서기를 가동해 볼까..?", "저런.. 그렇지만 왕자님이라면 오셔야겠죠? 반 드 시");

        var root = new DialogueNode(
            "안녕하세요. 로스트 아크 식당입니다. 저희식당은 순수 100% XX을 갈아서 음식을 제공하고 있습니다.",
            node_payment.directorLine, node_apologize.directorLine);
        root.nextYes = node_payment;
        root.nextNo = node_apologize;

        currentNode = root;
    }
}
