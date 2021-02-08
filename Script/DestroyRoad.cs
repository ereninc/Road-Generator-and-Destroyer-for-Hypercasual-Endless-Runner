using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRoad : MonoBehaviour
{
    Rigidbody fizik;
    [SerializeField] private float Hiz = 10;
    
	void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

    void Update()
    {
        fizik.velocity = transform.forward * Hiz;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "yolTag")
        {
            Destroy(other.gameObject);
        }
    }
}