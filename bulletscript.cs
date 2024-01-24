using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject scoreManager;
    private Score score_script;

    private bool collided= false;

    void Start()
    {
        scoreManager= GameObject.Find("ScoreManager");
        score_script= scoreManager.GetComponent<Score>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col){
        if (col.gameObject.CompareTag("Enemy") && !collided){
            score_script.AddPoint();
            Destroy(col.gameObject);
            collided= true;
        }
        else if (col != null && col.gameObject.CompareTag("Enemy")){
            Destroy(gameObject);
            }
        // else if (col.gameObject.name=="bb8"){
            
        // }
    }
}
