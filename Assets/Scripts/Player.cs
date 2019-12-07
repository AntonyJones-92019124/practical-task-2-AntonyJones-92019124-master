using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject BallPrefab;
    public Vector3 BallOffset = new Vector3(0.5f, 0.5f, 0.5f); // offset from camera to create balls when throwing
    public int Score { get { return score; } }

    private int score;
   


    // Use this for initialization
    void Start () {
        score = 0;
    }

    void FixedUpdate()
    {
        if (Time.frameCount % 18 == 0) // throw a ball every 18th update
            ThrowBall();
    }

    private void ThrowBall()
    {
        // throw ball
        GameObject newBall = (GameObject)GameObject.Instantiate(BallPrefab, this.transform.position + BallOffset, this.transform.rotation);
        // add some randomness to throw vector
        Vector3 randVec = Random.insideUnitSphere;
        randVec.y *= 0.1f;
        // combine basic throw vector with randomness
        Vector3 throwVector = (new Vector3(-2f, 0.2f, 0f) + randVec) * 1400f;
        newBall.GetComponent<Rigidbody>().AddForce(throwVector);
    }

    public void IncreaseScore(int scoreChange)
    {
        score += scoreChange;        
    }
    void Throw()
    {
        GameObject obj = NewObjectPoolerScript.current.GetPooledObject();

        if (obj = null) return;

        obj.transform.position = transform.position;
        obj.transform.rotation = transform.rotation;
        obj.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
