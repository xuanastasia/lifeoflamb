using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move1 : MonoBehaviour

{

    public float Speed; 
    public float Decrease;
        

    void Update()
    {
        Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Target.z = transform.position.z; 

        transform.position = Vector3.MoveTowards(transform.position, Target, Speed * Time.deltaTime/ transform.localScale.x);

        transform.localScale -= new Vector3(Decrease, Decrease, Decrease);


    
    

    }
}
