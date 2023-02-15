using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCountBallsBonus : MonoBehaviour
{
    [SerializeField] private GameObject _ballsContainer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Platform platform))
        {
            Destroy(gameObject);
            GameOver.countBalls += 3;
            Instantiate(_ballsContainer);
        }
    }
}
