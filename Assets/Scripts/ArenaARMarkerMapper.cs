using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArenaUnity;
using ArenaUnity.Components;

public class ArenaARMarkerMapper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.M)) {
            FindAll();
        }

    }


    void FindAll() {
    
        ArenaArmarker[] foundArmarkerObjects = FindObjectsOfType<ArenaArmarker>();
    
        Debug.Log(foundArmarkerObjects + " : " + foundArmarkerObjects.Length);

    }

}
