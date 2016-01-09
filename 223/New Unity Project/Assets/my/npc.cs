using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class npc : MonoBehaviour {
    public float time = 1;
    float upadateTiem;
    public float ballSpeed=0.1f;

    public GameObject ball;
    public GameObject targetNpc;
    

    public List<GameObject> balls;

	// Use this for initialization
	void Start () {
	       
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > upadateTiem)
        {
            upadateTiem = Time.time + time;
            if (targetNpc != null && ball != null)
            {
                balls.Add(GameObject.Instantiate(ball, transform.position, Quaternion.identity) as GameObject);
                balls[balls.Count - 1].transform.SetParent(transform.parent);
            }
        }
        for (int i = balls.Count-1; i>0; i--)
        {
            //if(Vector3.Distance(balls[i].transform.position, targetNpc.transform.position)<0.1f){
            //    Destroy(balls[i]);
            //    break;
            //}
               
            balls[i].transform.position = Vector3.MoveTowards(balls[i].transform.position, targetNpc.transform.position, ballSpeed);
        }
	}
}
