using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewObjectPoolerScript : MonoBehaviour {

    public static NewObjectPoolerScript current;
    public GameObject pooledObject;
    public int pooledAmount = 20; //Set the Variable pooledAmount to interger 20
    public bool willGrow = true; //Set Variable willGrow to boolean value true


    List<GameObject> pooledObjects;
    
    void Awake ()
    {

    }

	// Use this for initialization
	void Start () {
        pooledObjects = new List<GameObject>(); // Create a new List of GameObjects
        for (int i = 0; i < pooledAmount; i ++) //For loop interates the pooled list while true
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);//Set the variable obj to the value of GameObject
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
	}

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        if (willGrow)
        {
            GameObject obj = (GameObject)Instantiate(pooledObject);
            pooledObjects.Add(obj);
            return obj;
        }
        return null;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
