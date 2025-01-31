﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioEndTriggerHouse : MonoBehaviour
{
    public GameObject startTrigger;
    public GameObject altEnd;
    public string endtext;
    
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
   // {
        
    //}

    private void OnTriggerEnter(Collider other) {
        //Debug.Log("Trigger entered by " + other.gameObject.name);
        if (other.gameObject.name == "VehicleCoords") {
            Debug.Log("Ending scenario for " + other.gameObject.name);
            other.GetComponent<VehicleScenario>().EndScenario(endtext);
        }
        if (altEnd.name == "VehicleCoords") {
            other.GetComponent<VehicleScenario>().EndScenario("you destroyed the house!");
            altEnd.SetActive(false);
        }
    }
}
