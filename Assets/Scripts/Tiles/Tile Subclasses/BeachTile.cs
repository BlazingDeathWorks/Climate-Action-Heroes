using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DonutStudios.Tiles
{
    internal class BeachTile : Tile
    {
        [SerializeField] private StoneTile _stoneTile;
        [SerializeField] private float _spawnRate = 30;
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
                Destroy(gameObject);
                Instantiate(_stoneTile, transform.position, Quaternion.identity);
            }
        }
    }
}
