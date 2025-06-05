using UnityEngine;

public class UISplashSequencer : MonoBehaviour
{
    public Animator logoAnimator;      // Image_Logo�� Animator
    public Animator warningAnimator;   // Image_Warning�� Animator
    public Animator mainUIAnimator;    // Image_MainUI�� Animator

    void Start()
    {
        // ��� �����ϰ� �ʱ�ȭ!
        logoAnimator.GetComponent<CanvasGroup>().alpha = 0f;
        warningAnimator.GetComponent<CanvasGroup>().alpha = 0f;
        mainUIAnimator.GetComponent<CanvasGroup>().alpha = 0f;

        StartCoroutine(PlaySequence());
    }

    System.Collections.IEnumerator PlaySequence()
    {
        // 1. �ΰ� (Clip �̸�: "New Animation")
        logoAnimator.Play("New Animation");
        yield return new WaitForSeconds(4.0f); // �ΰ� ���� �ð�

        // 2. ���� (Clip �̸�: "New Animation1")
        warningAnimator.Play("New Animation1");
        yield return new WaitForSeconds(3.0f); // ���� ���� �ð�

        // 3. ����UI (Clip �̸�: "New Animation3")
        mainUIAnimator.Play("New Animation3");
        // ����UI�� ��� ����!
    }
}
