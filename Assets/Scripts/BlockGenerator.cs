using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _blockPrefab;
    [SerializeField] private List<Transform> _blockPositions;

    private void Start()
    {
        foreach(var item in _blockPositions)
        {
            var block = Instantiate(_blockPrefab, item.position, Quaternion.identity);
            block.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
        }
    }
}
