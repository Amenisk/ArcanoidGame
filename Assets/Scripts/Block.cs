using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] private GameObject bonus;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        bonus.transform.position = gameObject.transform.position;
        Destroy(gameObject);
        Instantiate(bonus); 
    }
}
