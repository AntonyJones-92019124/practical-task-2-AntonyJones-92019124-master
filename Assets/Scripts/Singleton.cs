using UnityEngine;
using System.Collections;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{

    private static T _instance;  //Becuase this is a generic class the instance is set to type <T>

    public static T Instance   //Instance set to static so it can be accessed from any other class withoutout a reference to the the instance of the sington object
    {
        get
        {
            // Check if the instance is null.
            if (_instance == null)
            {
                // First try to find the object already in the scene.
                _instance = GameObject.FindObjectOfType<T>();

                if (_instance == null)
                {
                    // Couldn't find the singleton in the scene, so make it.
                    GameObject singleton = new GameObject(typeof(T).Name);
                    _instance = singleton.AddComponent<T>();
                }
            }

            return _instance;
        }
    }
}