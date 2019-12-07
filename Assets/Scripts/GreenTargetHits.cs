using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTargetHits : MonoBehaviour
{
    public int ScoreIncrease = 0;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("OnTriggerEnter");
        //Player player = GameObject.Find("Main Camera").GetComponent<Player>();
        //player.IncreaseScore(ScoreIncrease);
        //GameObject.Destroy(other.gameObject);

        if (other.gameObject.tag == "Ball")
        {
            Pickup();
        }
    }

    private void Pickup()
    {
        GameManager.Instance.Score += 100;
    }
}
