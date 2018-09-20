using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TrackedArm : MonoBehaviour {
    public static TrackedArm instance;

    private void Awake() {
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
    }

    public Vector3 GetViveTrackerPosition(){
        return transform.position;
    }
}