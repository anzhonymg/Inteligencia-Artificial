using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{   
    //float tx = 0;
    //float ty = 0;
    //float ty = 20;
//    float minX = -5;
    //float withX = -5;
//    float width = 10;
//    float height = 10; 
    void Update(){
        //ty += 0.01f;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.Scale(new Vector3(1, 1, 0));
        transform.position = mousePosition;
        //tx += 0.01f;
        //ty += 0.01f;        
       // float x = 10 * Mathf.PerlinNoise(tx, 0);
        //float y = 10 * Mathf.PerlinNoise(ty, 0);
        //transform.position = new Vector3(x, y, 0);
        //tx += 0.01f;
        //float x = -5 + 10 * Mathf.PerlinNoise(tx, 0);
       // float y = -5 + 10 * Mathf.PerlinNoise(0, ty);
        //transform.position = new Vector3(x, y, 0); 
    }
}
