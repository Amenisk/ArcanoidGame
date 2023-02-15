using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleBlock : MonoBehaviour
{
    private bool isCollision;
    [SerializeField] private GameObject bonus;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(isCollision)
        {
            bonus.transform.position = gameObject.transform.position;
            Destroy(gameObject);   
            Instantiate(bonus);
        }
        
        isCollision = true;
        this.GetComponent<SpriteRenderer>().color = Color.red;
    }
}
