using UnityEngine;

public class UISplashSequencer : MonoBehaviour
{
    public Animator logoAnimator;      // Image_Logo의 Animator
    public Animator warningAnimator;   // Image_Warning의 Animator
    public Animator mainUIAnimator;    // Image_MainUI의 Animator

    void Start()
    {
        // 모두 투명하게 초기화!
        logoAnimator.GetComponent<CanvasGroup>().alpha = 0f;
        warningAnimator.GetComponent<CanvasGroup>().alpha = 0f;
        mainUIAnimator.GetComponent<CanvasGroup>().alpha = 0f;

        StartCoroutine(PlaySequence());
    }

    System.Collections.IEnumerator PlaySequence()
    {
        // 1. 로고 (Clip 이름: "New Animation")
        logoAnimator.Play("New Animation");
        yield return new WaitForSeconds(4.0f); // 로고 연출 시간

        // 2. 워닝 (Clip 이름: "New Animation1")
        warningAnimator.Play("New Animation1");
        yield return new WaitForSeconds(3.0f); // 워닝 연출 시간

        // 3. 메인UI (Clip 이름: "New Animation3")
        mainUIAnimator.Play("New Animation3");
        // 메인UI는 계속 노출!
    }
}
