using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallThrower : MonoBehaviour {

    public float ballThrowerTime = .05f;    //Set variable ballThrowerTime to .05 seconds
    public GameObject BallPrefab; //Call GameObject Ball

    public int pooledAmount = 20;   //Create 20 balls on start up
    List<GameObject> balls; //Create List of balls

    // Use this for initialization
    void Start()
    {
        balls = new List<GameObject>(); //Create new list for for GameObjects balls
        for (int i = 0; i < pooledAmount; i++)
        {
            GameObject obj = (GameObject)Instantiate(BallPrefab);
            obj.SetActive(false);
            balls.Add(obj);
        }

        InvokeRepeating("Fire", ballThrowerTime, ballThrowerTime);
    }

    void Throw ()
    {       
        for (int i =0; i < balls.Count; i++)
        {
            if(balls[i].activeInHierarchy)
            {
                balls[i].transform.position = transform.position;
                balls[i].transform.rotation = transform.rotation;
                balls[i].SetActive(true);
                break;
            }
        }
    }

    // Update is called once per frame
        void Update () {
		
	}
}
