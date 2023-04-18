using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FutureInspireGames.Singleton;
using UnityEngine.UI;

namespace DonutStudios.Meters
{
    public class ItemManager : Singleton<ItemManager>
    {
        public int Meat { get; private set; }
        public int Crop { get; private set; } 
        public int Metal { get; private set; }
        [SerializeField] private Slider _meatBar, _cropBar, _metalBar;

        public void IncreaseMeat(int value)
        {
            Meat += value;
            _meatBar.value = Meat;
        }
        public void IncreaseCrop(int value)
        {
            Crop += value;
            _cropBar.value = Crop;
        }
        public void IncreaseMetal(int value)
        {
            Metal += value;
            _metalBar.value = Metal;
        }

        public int GetMeat()
        {
            int meat = Meat;
            Meat = 0;
            _meatBar.value = Meat;
            return meat;
        }
    }
}
