using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Tiles
{
    internal class DesertTileStructure : TileStructure
    {
        private void FillRow(int widthCount, int rightPos, int leftPos, int height)
        {
            Instantiate(Tile, new Vector3(transform.position.x, height, -9), Quaternion.identity).GetComponent<Tile>().Parent = Parent;
            while (widthCount < Width)
            {
                if (widthCount % 2 == 0)
                {
                    rightPos++;
                    Instantiate(Tile, new Vector3(rightPos, height, -9), Quaternion.identity).GetComponent<Tile>().Parent = Parent;
                }

                else
                {
                    leftPos--;
                    Instantiate(Tile, new Vector3(leftPos, height, -9), Quaternion.identity).GetComponent<Tile>().Parent = Parent;
                }

                widthCount++;
            }
        }

        internal override void Fill(TileStructureBuilder builder)
        {
            if (transform.position.x + Width > Parent.MaxCornerPos.x)
            {
                transform.position = new Vector2((int)transform.position.x - Width, (int)transform.position.y);
            }
            if (transform.position.x - Width < Parent.MinCornerPos.x)
            {
                transform.position = new Vector2((int)transform.position.x + Width, (int)transform.position.y);
            }

            int widthCount = 0;
            int rightPos = (int)transform.position.x;
            int leftPos = (int)transform.position.x;

            if (transform.position.y + Height > Parent.MaxCornerPos.x)
            {
                transform.position = new Vector2((int)transform.position.x, (int)transform.position.y - Height);
            }
            if (transform.position.y - Height < Parent.MinCornerPos.x)
            {
                transform.position = new Vector2((int)transform.position.x, (int)transform.position.y + Height);
            }

            int heightCount = 0;
            int upPos = (int)transform.position.y;
            int downPos = (int)transform.position.y;

            FillRow(widthCount, rightPos, leftPos, (int)transform.position.y);
            while (heightCount < Height)
            {
                if (heightCount % 2 == 0)
                {
                    upPos++;
                    FillRow(widthCount, rightPos, leftPos, upPos);
                }
                else
                {
                    downPos--;
                    FillRow(widthCount, rightPos, leftPos, downPos);
                }

                heightCount++;
            }
        }
    }
}
