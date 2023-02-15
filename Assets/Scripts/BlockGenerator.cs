using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    [SerializeField] private GameObject _blockPrefab;
    [SerializeField] private GameObject _blockDoublePrefab;
    [SerializeField] private List<Transform> _blockPositions;

    private void Start()
    {
        foreach(var item in _blockPositions)
        {
            GameObject block;

            if(Random.Range(0, 2) == 0)
            {
                block = Instantiate(_blockPrefab, item.position, Quaternion.identity);
            }
            else
            {
                block = Instantiate(_blockDoublePrefab, item.position, Quaternion.identity);
            }

            block.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
        }
    }
}
