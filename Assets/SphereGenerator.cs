using UnityEngine;
using System.Collections;

public class SphereGenerator : MonoBehaviour {
    public GameObject SpherePrefab; 
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Sphere =
                Instantiate(SpherePrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            Sphere.GetComponent<SphereCollider>().Shoot(
                worldDir.normalized * 2000);
        }	
	}
}
