using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class drinkwine : MonoBehaviour
{
    public string Tag; 
    public float Increase; 

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == Tag)
        {
            transform.localScale += new Vector3(Increase, Increase, Increase);
            Destroy(other.gameObject);

            ScoreManager.instance.AddPoint();   
        }
    }
}
