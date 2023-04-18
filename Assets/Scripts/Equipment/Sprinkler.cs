using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Equipment
{
    internal class Sprinkler : Equipment
    {
        protected override void OnTriggerEnterEvent(Collider2D collision)
        {
            base.OnTriggerEnterEvent(collision);
            if (!IsFunctional) return;
            Crop crop = collision.GetComponent<Crop>();
            if (crop == null) return;
            crop.GrowingSpeed = 2;
        }
    }
}
