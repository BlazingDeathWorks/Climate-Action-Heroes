using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Tiles
{
    internal abstract class TileStructureBuilder : MonoBehaviour
    {
        //Boundaries
        internal abstract Vector2 MinCornerPos { get; }
        internal abstract Vector2 MaxCornerPos { get; }
        internal int HalfPos { get; private protected set; }

        [SerializeField] private protected TileStructureBuilder ChildBuilder;
        [SerializeField] private protected TileStructure TileStructure;
        private protected TileStructureBuilder ParentBuilder { get; set; }

        //Number of structure center points to spawn
        private protected abstract int Points { get; }
        private protected TileStructure[] Structures { get; set; }

        private protected abstract void CreateStructures();

        private protected virtual void Awake()
        {
            Structures = new TileStructure[Points];
            CreateStructures();
            for (int i = 0; i < Structures.Length; i++)
            {
                Structures[i].Fill(this);
            }
            /*TileManager.Instance.AddCheck();*/
        }
    }
}
