using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {


    private void OnCollisionEnter(Collision other)
    {   
            Destroy(gameObject);   
    }
}
