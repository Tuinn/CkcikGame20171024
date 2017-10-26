using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour {
    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }
    private void Start()
    {
         //Shoot(new Vecto3(0, 200, 2000));
    }


}
