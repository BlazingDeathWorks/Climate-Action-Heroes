using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FutureInspireGames.Channels;

namespace DonutStudios.Tiles
{
    internal abstract class Tile : MonoBehaviour
    {
        internal TileStructureBuilder Parent { private protected get; set; }
        /*[SerializeField] private ActionChannel _tileBuildFinished;
        [SerializeField] private ActionChannel _tileWipeFinished;*/
        /*private bool _wipeTiles = false;*/
        /*private SpriteRenderer _sr;*/

        /*private void Awake()
        {
            _sr = GetComponent<SpriteRenderer>();
        }*/

        private void Start()
        {
            if (transform.position.x >= (int)Parent.MinCornerPos.x && transform.position.x <= (int)Parent.MaxCornerPos.x &&
                transform.position.y >= (int)Parent.MinCornerPos.y && transform.position.y <= (int)Parent.MaxCornerPos.y)
            {
                /*_tileBuildFinished.AddAction(EnableWipe);
                _tileWipeFinished.AddAction(DisableWipe);*/
                return;
            }
            Destroy(gameObject);
        }

        /*private void OnDestroy()
        {
            _tileBuildFinished.RemoveAction(EnableWipe);
            _tileWipeFinished.RemoveAction(DisableWipe);
        }*/

        /*private void OnTriggerStay2D(Collider2D collision)
        {
            if (!_wipeTiles) return;
            Debug.Log("Hello");
            SpriteRenderer collidedSr = collision.GetComponent<SpriteRenderer>();
            if (_sr.sortingOrder >= collidedSr.sortingOrder)
            {
                Destroy(collision.gameObject);
                return;
            }
            Destroy(gameObject);
        }*/

        private void OnMouseDown()
        {
            Interact();
        }

        /*private void DisableWipe()
        {
            _wipeTiles = false;
        }

        private void EnableWipe()
        {
            _wipeTiles = true;
        }*/

        private protected virtual void Interact()
        {
            Debug.Log(gameObject.name);
        }
    }
}
