using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObjectPool pool;
    public float intervalTime;

    private float currentTime = 0;

    int spawns = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;

        if (currentTime > intervalTime)
        {
            GameObject o = pool.GetInactiveGameObject();

            int rnd = Random.Range(0,2);
            if (rnd == 0)
                o.GetComponent<Renderer>().material.color = Color.red;
            else
                o.GetComponent<Renderer>().material.color = Color.green;

            float x = Random.Range(-this.gameObject.transform.localScale.x / 2, this.gameObject.transform.localScale.x / 2);
            o.transform.position = (new Vector3(x, this.transform.position.y, 0));

            o.SetActive(true);
            spawns++;
            if (spawns >= 3 && intervalTime > 0.5f)
            {
                intervalTime -= 0.5f;
                spawns = 0;
            }

            currentTime = 0;
        }
    }
}
