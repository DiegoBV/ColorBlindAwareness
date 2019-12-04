using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<FallDown>())
        {
            collision.gameObject.SetActive(false);
            if(collision.gameObject.GetComponent<Renderer>().material.color == Color.green)
            {
                GameManager.instance.decrLifes();
            }
        }
    }
}
