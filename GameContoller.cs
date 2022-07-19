using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContoller : MonoBehaviour
{
    [Header("Set Resurs for City")]
    public float spawm_delay = 0.005f;
    public float spawn_radius = 4f;
    public GameObject prefabsSpawnObj;
    public Transform spawn_point;
    public Vector3 volume;
    int spawn_count = 20;
    bool spawn_check = true;

    public void Update()
    {
        if (spawn_check)
        {
            StartCoroutine("Spawn_resurs");
        }
    }

    IEnumerator Spawn_resurs() 
    {
        GameObject parent = new GameObject();
        while (spawn_count>0)
        {
            spawn_count--;
            Vector3 pos = new Vector3(Random.Range(spawn_point.position.x - volume.x, spawn_point.position.x + volume.x), spawn_point.position.y,Random.Range(spawn_point.position.z - volume.z,spawn_point.position.z + volume.z) );
            GameObject obj = Instantiate(prefabsSpawnObj, pos, Quaternion.identity, parent.transform);
            yield return new WaitForSeconds(spawm_delay);
        }
        spawn_check = false;
    }
}
