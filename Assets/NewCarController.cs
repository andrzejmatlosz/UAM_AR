using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCarController : MonoBehaviour {

    public CacheController cacheController;

	// Use this for initialization
	void Start () {
        cacheController.car = this.gameObject;
    }
}
