using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Equipment
{
    internal class ElectricPole : Equipment
    {
        protected override void OnTriggerEnterEvent(Collider2D collision)
        {
            base.OnTriggerEnterEvent(collision);
            Equipment equipment = collision.GetComponent<Equipment>();
            if (equipment == null) return;
            equipment.IsFunctional = true;
        }
    }
}
