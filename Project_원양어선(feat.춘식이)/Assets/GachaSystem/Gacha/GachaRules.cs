using System.Collections.Generic;
using UnityEngine;

public static class GachaRules
{
    // Èñ±Íµµº° °¡ÁßÄ¡(¿¹½Ã °ª)
    private static readonly Dictionary<int, float> weight = new()
    {
        { 5, 0.01f },   // 1 %
        { 4, 0.09f },   // 9 %
        { 3, 0.90f }    // 90 %
    };

    public static int RollRarity()
    {
        float r = Random.value;
        float acc = 0f;
        foreach (var kv in weight)
        {
            acc += kv.Value;
            if (r <= acc) return kv.Key;
        }
        return 3; // fallback
    }
}