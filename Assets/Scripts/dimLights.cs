using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dimLights : MonoBehaviour {

    private bool rotate = true;
    private bool stage1 = true;
    public float rateX;

    // Start is called before the first frame update
    void Start() {


    }

    // Update is called once per frame
    void Update() {

        if(rotate) {

            Debug.Log(transform.eulerAngles);
            if(stage1 && transform.eulerAngles.x > 0) {

                transform.Rotate(rateX, 0, 0);
            }
            else if(stage1) {

                stage1 = false;
                transform.Rotate(rateX, 0, 0);
                rateX /= 5;
            }
            else if(transform.eulerAngles.x > 353) {
                
                transform.Rotate(rateX, 0, 0);
            }
            else
                rotate = false;
        }
    }
}
