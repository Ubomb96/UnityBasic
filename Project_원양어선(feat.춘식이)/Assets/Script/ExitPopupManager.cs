using UnityEngine;

public class ExitPopupManager : MonoBehaviour
{
    public GameObject backgroundOverlay; // ��ο� ��� ������Ʈ
    public GameObject exitPopup;         // �˾�â ������Ʈ

    // "���� ����" ��ư Ŭ�� �� ȣ��
    public void ShowExitPopup()
    {
        backgroundOverlay.SetActive(true);
        exitPopup.SetActive(true);
    }

    // ���/�˾� �ݱ� (�������̳� "���" ��ư Ŭ��)
    public void HideExitPopup()
    {
        backgroundOverlay.SetActive(false);
        exitPopup.SetActive(false);
    }
}
