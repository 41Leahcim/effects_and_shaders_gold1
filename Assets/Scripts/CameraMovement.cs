using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour{
    [SerializeField] private Transform[] movementPoints;
    [SerializeField] private float speed;
    private int index = 0;

    void Update(){
        transform.position = Vector3.MoveTowards(transform.position, movementPoints[index].position, speed * Time.deltaTime);
        if(transform.position == movementPoints[index].position){
            index = (index + 1) % movementPoints.Length;
        }
    }
}
