using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnenemies : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public GameObject spawnpoint;
    int interval = 7;
    float prevtime;
    void Start()
    {
        prevtime= Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float currTime= Time.time;
        if(currTime- prevtime>= interval) {
            GameObject newEnemy= GameObject.Instantiate(enemy, spawnpoint.transform.position, spawnpoint.transform.rotation) as GameObject;   
            newEnemy.GetComponent<Rigidbody>().velocity += Vector3.up *2;
            // newEnemy.GetOrAddComponent<Rigidbody>().AddForce(newEnemy.transform.forward *1500);
            prevtime=Time.time;

            
        }
    }
}
