using System.Collections.Generic;
using UnityEngine;

public static class GachaRules
{
    // Èñ±Íµµº° °¡ÁßÄ¡(¿¹½Ã °ª)
    private static readonly Dictionary<int, float> weight = new()
    {
        { 5, 0.01f },   // 10 %
        { 4, 0.49f },   // 40 %
        { 3, 0.50f }    // 50 %
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