using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContlloer2 : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    private Rigidbody rb;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   //毎フレーム力を入れる
       rb.AddForce(Player.transform.position - transform.position);
    }
}
