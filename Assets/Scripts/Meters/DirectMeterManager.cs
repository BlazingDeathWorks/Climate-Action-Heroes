using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using FutureInspireGames.Singleton;

namespace DonutStudios.Meters
{
    internal class DirectMeterManager : Singleton<DirectMeterManager>
    {
        public float HungerLevel { get; set; } 
        public float ThirstLevel { get; set;}
        [SerializeField] private float _decreaseSpeed = 1;
        [SerializeField] private Slider _hungerBar;
        [SerializeField] private Slider _thirstBar;

        protected override void Awake()
        {
            base.Awake();
            HungerLevel = _hungerBar.maxValue;
            ThirstLevel = _thirstBar.maxValue;
        }

        private void Update()
        {
            HungerLevel -= _decreaseSpeed * Time.deltaTime;
            ThirstLevel -= _decreaseSpeed * Time.deltaTime;

            _hungerBar.value = HungerLevel;
            _thirstBar.value = ThirstLevel;
        }

        public void IncrementDecreaseSpeed(float value)
        {
            _decreaseSpeed += value;
        }
    }
}
