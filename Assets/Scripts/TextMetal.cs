﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextMetal : MonoBehaviour {
	public int ReqM=0;
	// Use this for initialization
	void Start () {
		ReqM=UnityEngine.Random.Range(1,11);
	}
	
	// Update is called once per frame
	void Update () {
	}

	public int ReturnReqM(){
		return ReqM;
	}

	public void NewReqM(){
		ReqM=UnityEngine.Random.Range(1,11);
	}
}
