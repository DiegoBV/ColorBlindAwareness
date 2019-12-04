using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickGreenGum : MonoBehaviour, IPointerClickHandler
{
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("kk");
        if(rend.material.color == Color.green)
        {
            gameObject.SetActive(false);
            GameManager.instance.incrScore(10);
        }
        else
        {
            GameManager.instance.incrScore(-10);
        }
    }
}
