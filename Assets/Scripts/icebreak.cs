using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icebreak : MonoBehaviour
{
    public float shakeTime = 1f;
    public float spawnTime = 1f;

    IEnumerator destroyIce()
    {
        yield return new WaitForSeconds(shakeTime);
        gameObject.GetComponent<Renderer>().enabled = false;
        gameObject.GetComponent<Collider2D>().enabled = false;
        Debug.Log("Ice destroyed");
        yield return new WaitForSeconds(spawnTime);
        gameObject.GetComponent<Renderer>().enabled = true; 
        gameObject.GetComponent<Collider2D>().enabled = true;  
        Debug.Log("Ice should be back");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == "Player" && collision.gameObject.transform.position.y > gameObject.transform.position.y)
        {
            StartCoroutine(destroyIce());
        }
    }
}
