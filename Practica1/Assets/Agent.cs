using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Agent : MonoBehaviour
{
    Vector3 velocity = Vector3.zero;
    Vector3 desired = Vector3.zero;
    Vector3 steer = Vector3.zero;
    float maxSpeed = 5;
    float maxSteer = 5;

    Transform target;

    void Update(){
        target = GameObject.Find("Target").transform;

        desired = (target.position - transform.position).normalized * maxSpeed;
        //desired = -(target.position - transform.position).normalized * maxSpeed;
        steer = Vector3.ClampMagnitude(desired - velocity, maxSteer);

        //velocity += steer;
        velocity += steer * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
        
        if(transform.position.x <= -7.6 || transform.position.y >= 7.6 || transform.position.x <= -2.06 || transform.position.y >= 6.84) 
        {   
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Destroy(gameObject);
            Debug.Log("Destruido");
            
        }
    } 
}
