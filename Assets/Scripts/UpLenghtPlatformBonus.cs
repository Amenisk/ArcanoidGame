using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpLenghtPlatformBonus : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Platform platform))
        {
            Destroy(gameObject);
            if(collision.gameObject.GetComponent<Platform>().transform.localScale.x == 3)
            {
                collision.gameObject.GetComponent<Platform>().transform.localScale = new Vector3(4.5f, 0.5f, 1);
            }
            else
            {
                collision.gameObject.GetComponent<Platform>().transform.localScale = new Vector3(9, 0.5f, 1);
            }
            
        }
    }
}
