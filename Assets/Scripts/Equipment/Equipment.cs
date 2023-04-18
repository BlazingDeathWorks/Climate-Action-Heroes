using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DonutStudios.Meters;

namespace DonutStudios.Equipment
{
    public class Equipment : MonoBehaviour
    {
        //Electricity cost
        //Tile radius (trigger)
        //List of allowable tiles to place on
        //Carbon cost
        //Metal cost
        //Method - PlaceDown
        [SerializeField] internal bool IsFunctional = false;
        [SerializeField] protected int ElectricityCost;
        [SerializeField] protected int MetalCost;
        [SerializeField] protected string[] AllowableTiles;
        [SerializeField] protected int CarbonCost;

        private void Awake()
        {
            gameObject.SetActive(false);
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            OnTriggerEnterEvent(collision);
        }

        protected virtual void OnTriggerEnterEvent(Collider2D collision)
        {

        }

        protected bool CheckTileLayer(string layerName)
        {
            for (int i = 0; i < AllowableTiles.Length; i++)
            {
                if (AllowableTiles[i] == layerName) return true;
            }
            return false;
        }

        protected bool CheckCosts()
        {
            if (ElectricityManager.Instance.ElectricityAvailable >= ElectricityCost && ItemManager.Instance.Metal >= MetalCost)
            {
                ElectricityManager.Instance.ElectricityAvailable -= ElectricityCost;
                ElectricityManager.Instance.UpdateElectricitySlider();
                ElectricityManager.Instance.ClampElectricityAmount();

                ItemManager.Instance.Metal -= MetalCost;
                ItemManager.Instance.UpdateMetalSlider();
                return true;
            }
            return false;
        }

        //This is called when right clicked in Tile script - Spawns equipment disables it and runs this method
        //CheckTileLayer, CheckCosts, Then whatever
        public virtual void PlaceDown(GameObject tile, string layerName)
        {
            if (!CheckTileLayer(layerName) || !CheckCosts())
            {
                Destroy(gameObject);
                return;
            }
            Destroy(tile);
            gameObject.SetActive(true);
        }
    }
}
