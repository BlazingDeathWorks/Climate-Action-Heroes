using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Tiles
{
    internal class MathUtil : MonoBehaviour
    {
        internal static bool PercentChance(int percentChance)
        {
            int rand = Random.Range(1, 11);
            if (percentChance >= rand) return true;
            return false;
        }
    }
}
