using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FutureInspireGames.Singleton;

namespace DonutStudios.Equipment
{
    public class EquipmentManager : Singleton<EquipmentManager>
    {
        [SerializeField] private Equipment[] _equipments;
        private int _index = 1;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                _index = 1;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                _index = 2;
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                _index = 3;
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                _index = 4;
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                _index = 5;
            }
            if (Input.GetKeyDown(KeyCode.Alpha6))
            {
                _index = 6;
            }
        }

        public Equipment GetCurrentEquipment()
        {
            if (_index > _equipments.Length) return null;
            return _equipments[_index - 1];
        }
    }
}
