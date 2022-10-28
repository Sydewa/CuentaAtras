using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if(GetComponent<Collider>().gameObject.CompareTag("FinishLine"))
        {
            GameManager.Instance.LevelFinisher();
        }
    }
}
