using UnityEngine;

public class ExitPopupManager : MonoBehaviour
{
    public GameObject backgroundOverlay; // 어두운 배경 오브젝트
    public GameObject exitPopup;         // 팝업창 오브젝트

    // "게임 종료" 버튼 클릭 시 호출
    public void ShowExitPopup()
    {
        backgroundOverlay.SetActive(true);
        exitPopup.SetActive(true);
    }

    // 배경/팝업 닫기 (오버레이나 "취소" 버튼 클릭)
    public void HideExitPopup()
    {
        backgroundOverlay.SetActive(false);
        exitPopup.SetActive(false);
    }
}
