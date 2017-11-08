using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelRun : MonoBehaviour {

    void OnEnable()
    {
        //for (int i = 0; i <= 400; i++)
        //{
        //    this.transform.Translate(new Vector3(0, 0, 0.1f));
        //}
        //this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 1));
        this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.up * 0.01f;
    }
	void Update () {
        //this.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,1));
        //this.transform.Translate(new Vector3(0, 0, 0.1f));
	}

    IEnumerator addForce()
    {
        yield return null;
        this.transform.Translate(new Vector3(0, 0, 0.1f));
    }
}
