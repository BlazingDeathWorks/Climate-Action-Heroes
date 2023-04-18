using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Meters
{
    internal class Animal : MonoBehaviour
    {
        private void OnMouseDown()
        {
            Destroy(gameObject);
            ItemManager.Instance.IncreaseMeat(5);
            DirectMeterManager.Instance.TemperatureLevel += 1;
            DirectMeterManager.Instance.UpdateTemperature();
        }
    }
}
