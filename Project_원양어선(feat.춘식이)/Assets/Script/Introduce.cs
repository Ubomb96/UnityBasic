using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduce : MonoBehaviour
{
    Player p = new Player();

    void Start()
    {
        p.SelfIntroduction();
        p.SelfIntroduction("������", 27);
    }
}

public class Player
{
    public string Name = "���߿�";
    public int age = 30;

    public void SelfIntroduction()
    {
        Debug.Log($"���� {Name}�̰�, ���̴� {age}���Դϴ�.");
    }

    public void SelfIntroduction(string name, int age)
    {
        Debug.Log($"���� {name}�̰�, ���̴� {age}���Դϴ�.");
    }
}
