using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCountBallsBonus : MonoBehaviour
{
    [SerializeField] private GameObject _ballsContainer;
    [SerializeField] private GameOver _ballsCount;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Platform platform))
        {
            Destroy(gameObject);
            Instantiate(_ballsContainer);
        }
    }
}
