using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduce : MonoBehaviour
{
    Player p = new Player();

    void Start()
    {
        p.SelfIntroduction();
        p.SelfIntroduction("조형민", 27);
    }
}

public class Player
{
    public string Name = "원중완";
    public int age = 30;

    public void SelfIntroduction()
    {
        Debug.Log($"저는 {Name}이고, 나이는 {age}살입니다.");
    }

    public void SelfIntroduction(string name, int age)
    {
        Debug.Log($"저는 {name}이고, 나이는 {age}살입니다.");
    }
}
