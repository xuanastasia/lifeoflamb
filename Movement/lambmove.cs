using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lambmove : MonoBehaviour{

    public float Speed; 

    void Update()
    {
        Vector3 Target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Target.z = transform.position.z; 

        transform.position = Vector3.MoveTowards(transform.position, Target, Speed * Time.deltaTime/ transform.localScale.x);

    }
}
