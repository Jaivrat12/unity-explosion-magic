using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitExplosion : MonoBehaviour {

    public Vector3 location;
    public GameObject[] detonators;
    public float[] timeIntervals;

    private int objects, i = 0;


    // Start is called before the first frame update
    void Start() {

        objects = detonators.Length;
        location = transform.position;
    }

    // Update is called once per frame
    void Update() {

        if(i < objects && Time.time >= timeIntervals[i]) {

            //Detonator dTemp = (Detonator)currentDetonator.GetComponent("Detonator");

            //float offsetSize = dTemp.size/3;
            //Vector3 hitPoint = hit.point +
            //                          ((Vector3.Scale(hit.normal, new Vector3(offsetSize, offsetSize, offsetSize))));
            GameObject exp = (GameObject) Instantiate(detonators[i], location, Quaternion.identity);
            //dTemp = (Detonator)exp.GetComponent("Detonator");
            //dTemp.detail = detailLevel;

            //Destroy(exp, explosionLife);
            ++i;
        }
    }
}
