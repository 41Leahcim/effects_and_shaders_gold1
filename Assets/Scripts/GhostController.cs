using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostController : MonoBehaviour{
    void Start(){
        
    }

    void Update(){
        transform.Rotate(Vector3.up * 45 * Time.deltaTime);
    }
}
