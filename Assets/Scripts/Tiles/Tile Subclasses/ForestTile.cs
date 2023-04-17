using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Tiles
{
    internal class ForestTile : Tile
    {
        [SerializeField] private GameObject _animal;
        [SerializeField] private float _spawnRate = 45;
        [SerializeField] private int _percentChance = 1;
        private float _timeSinceLastSpawned;

        private protected override void Awake()
        {
            _timeSinceLastSpawned = _spawnRate;
            base.Awake();
        }

        private void Update()
        {
            _timeSinceLastSpawned += Time.deltaTime;

            if (_timeSinceLastSpawned >= _spawnRate)
            {
                _timeSinceLastSpawned = 0;
                if (!MathUtil.PercentChance(_percentChance)) return;
                Instantiate(_animal, transform.position, Quaternion.identity);
            }
        }

        private protected override void Interact()
        {
            Debug.Log("Forest");
        }
    }
}
