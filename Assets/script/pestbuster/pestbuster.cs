﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pestbuster : MonoBehaviour {


    public GameObject pest;
    public float Maxx;
    public float Maxy;
    public float Minx;
    public float Miny;
    int i = 5;
    void Start () {

        while (i > 0)
        {

            Vector3 position = new Vector3(Random.Range(Minx, Maxx), Random.Range(Miny, Maxy),10);
            GameObject newpest=Instantiate(pest, position, pest.transform.rotation);
            newpest.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
            i--;
           
        }
    }
	

	void Update () {
		
	}
}
