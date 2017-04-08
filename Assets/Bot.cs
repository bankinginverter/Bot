using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public Transform player;
    float s = 1.0f;
    void Start ()
    {

    }
    void Update ()
    {
        FollowSet();
    }
    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            s = 0f;
            Debug.Log("Hit");
        }
    }
    public void FollowSet()
    {
        float botpositionZ = this.transform.position.z;
        float botpositionX = this.transform.position.x;
        float playerpositionZ = player.transform.position.z;
        float playerpositionX = player.transform.position.x;
        float sumpositionZ = botpositionZ - playerpositionZ;
        float sum = Vector3.Distance(this.transform.position, player.transform.position);
        checkAxisZ(sum,sumpositionZ);
        checkAxisX();
        //this.transform.position += new Vector3(s, 0, 0)*Time.deltaTime;
    }
    public void checkAxisZ(float sum,float sumpositionZ)
    {
        //if (sum >= Mathf.Floor(1f))
        //{
        //    s = 1f;
        //}
        //if (sumpositionZ >= Mathf.Floor(0f))
        //{
        //    this.transform.position += new Vector3(0f, 0f, -s) * Time.deltaTime;
        //}
        //if (sumpositionZ <= Mathf.Floor(0f))
        //{
        //    this.transform.position += new Vector3(0f, 0f, s) * Time.deltaTime;
        //}
    }
    public void checkAxisX()
    {
        Vector3 a = player.transform.position - this.transform.position;
        
    }
}
