using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Class that handle flyint unit movements */
public class PathPoint : MonoBehaviour
{
    //private int angle = 5;
    private GameObject rotationCenter;

    public GameObject[] waypoints;
    int currentWP = 0;
    public float speed = 1;
    public float rotSpeed = 1;
    void Start(){
        //this.GetComponent<Animator>().Play("1-walk_chase", 0, 0.25f);
    }

    /// <summary>
    /// The function is called every frame and it permit flying units to fly randomly in the middle on the map using 8 way points.
    /// </summary>
    void Update ()
    {
        if(Vector3.Distance(this.transform.position, waypoints[currentWP].transform.position) < 1)
            currentWP ++;

        Quaternion lookatWP = Quaternion.LookRotation(waypoints[currentWP].transform.position - this.transform.position);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, lookatWP, rotSpeed * Time.deltaTime);
        this.transform.Translate(0,0, speed*Time.deltaTime);
    }
    
}
