using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCitilzen : MonoBehaviour
{
    [Header("Set in Inspector")]
    public float speed = 2;
    public GameObject tribePrefabs;
   
   public float minValue, maxValue, randomX, randomY;
    bool npcGo;

    

    public void Start()
    {
        minValue = tribePrefabs.GetComponent<BoxCollider>().size.x;
        maxValue = tribePrefabs.GetComponent<BoxCollider>().size.z;
        randomX = Random.Range(1, maxValue);
        randomY = Random.Range(1, minValue);
        npcGo = false;
    }
    
   public void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        npcGo = false;
        if (transform.position.x <randomX)
        {
            speed = -speed;
            npcGo = true;
        }
        if (transform.position.x>randomY)
        {
            speed = 2;
            npcGo = true;
        }

        if ((transform.position.x < randomX||transform.position.x > randomY) && npcGo)
        {
         randomX = Random.Range(minValue, maxValue);
         randomY = Random.Range(minValue, maxValue);
            npcGo = false;
        }
    }
}
