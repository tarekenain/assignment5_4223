using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroywords : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "end")
            {
                // Aud.playSound();
                Debug.Log("word detroyed");
                Destroy(this.gameObject);
            }
        }
}
