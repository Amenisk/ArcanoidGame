using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Block : MonoBehaviour
{
    [SerializeField] private GameObject firstBonus;
    [SerializeField] private GameObject secondBonus;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(Random.Range(0, 7) == 0)
        {
            firstBonus.transform.position = gameObject.transform.position;
            Instantiate(firstBonus);
            Destroy(gameObject);
            return;
        }

        if (Random.Range(0, 9) == 0)
        {
            secondBonus.transform.position = gameObject.transform.position;
            Instantiate(secondBonus);
        }

        Destroy(gameObject);
    }
}
