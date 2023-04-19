using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Tiles
{
    internal class TileManager : MonoBehaviour
    {
        internal static TileManager Instance { get; private set; }
        [SerializeField] private int _checks;
        private int _checkCount;

        private void Awake()
        {
            Instance = this;
        }
    }
}
