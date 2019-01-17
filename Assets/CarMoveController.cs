using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoveController : MonoBehaviour {

    CacheController cacheController;
    private bool forward;
    private bool backwards;

    // Use this for initialization
    void Start () {
        cacheController = GetComponent<CacheController>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
		if (forward)
        {
            cacheController.car.transform.Translate(Vector3.up * 0.01f);
        }

        if (backwards)
        {
            cacheController.car.transform.Translate(Vector3.down * 0.01f);
        }
    }

    public void Stop()
    {
        forward = false;
        backwards = false;
    }

    public void MoveForward()
    {
        forward = true;
        backwards = false;
    }

    public void MoveBackwards()
    {
        backwards = true;
        forward = false;
    }
}
