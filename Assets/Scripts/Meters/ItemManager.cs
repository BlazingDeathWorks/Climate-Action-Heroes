using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FutureInspireGames.Singleton;
using UnityEngine.UI;

namespace DonutStudios.Meters
{
    public class ItemManager : Singleton<ItemManager>
    {
        public int Meat { get; set; }
        public int Crop { get; set; } 
        public int Metal { get; set; }
        [SerializeField] private Slider _meatBar, _cropBar, _metalBar;

        public void IncreaseMeat(int value)
        {
            Meat += value;
            Meat = Mathf.Clamp(Meat, 0, (int)_meatBar.maxValue);
            _meatBar.value = Meat;
        }
        public void IncreaseCrop(int value)
        {
            Crop += value;
            Crop = Mathf.Clamp(Crop, 0, (int)_cropBar.maxValue);
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
        public int GetCrop()
        {
            int crop = Crop;
            Crop = 0;
            _cropBar.value = Crop;
            return crop;
        }
        public void UpdateMetalSlider()
        {
            Metal = Mathf.Clamp(Metal, 0, (int)_metalBar.maxValue);
            _metalBar.value = Metal;
        }
    }
}
