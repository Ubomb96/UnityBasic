
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

// public class testscript : MonoBehaviour
// {
    // Start is called before the first frame update

    // public int gold = 0;

    // void Awake()
    // {
        // Debug.Log("�����ѹ� ����");
    // }

   // void OnEnable()
   // {
   //     Debug.Log("Ȱ��ȭ �� �� ����");   
   // }
    // void Start()
    // {
      //   Debug.Log("�ȳ��ϼ���");
       //  Debug.Log("�����ؿ�");
     //    UnityEngine.Debug.Log("���־��");
       //  UnityEngine.Debug.Log("�ٽø�����");
    // }

    // Update is called once per frame
   //  void Update()
    // {
      //   Debug.Log("������ ����");
    // }

   //  int Sum(int value1, int value2)
   //  { 
    //     return value1 + value2; 
  //   }
 //    void OnEnable()
  //   {
   //      Debug.Log(Random.Range(1, 100));
        // 1 �̻� 100 �̸��� ������ ���� ����ڴ�.

  //   }
// }
// public class Monster
// {
   //  testscript test;

   //  void Attack()
  //   {
    //     test.gold = 0;
  //   }

// }

public class testA : MonoBehaviour
{
    private string aname = "�Ļ�";
    private int MFD = 20;
    private float life = 1200.0f;

    void Start()
    {
        SelfIntroduction();
        SelfIntroduction(aname, MFD);

    }

    public void SelfIntroduction()
    {
        Debug.Log("�̰��� �̸���" + aname + "�Դϴ�.");
        Debug.Log("��������" + MFD + "�� �Դϴ�.");
        Debug.Log("�������� ������" + life + "�� ���ҽ��ϴ�.");

    }
    
    public void SelfIntroduction(string _aname, int _MFD)
    {
        Debug.Log("�̰�" + _aname + "��");
        Debug.Log("������" + _MFD + "��");
    }
}