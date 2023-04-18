using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DonutStudios.Equipment;

namespace DonutStudios.Tiles
{
    public abstract class Tile : MonoBehaviour
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

        private protected virtual void Awake()
        {
           
        }

        private protected virtual void Start()
        {
            if (Parent == null) return;

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

        private void OnMouseOver()
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                Instantiate(EquipmentManager.Instance.GetCurrentEquipment(), transform.position, Quaternion.identity).PlaceDown(gameObject, LayerMask.LayerToName(gameObject.layer));
            }
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
            
        }
    }
}
