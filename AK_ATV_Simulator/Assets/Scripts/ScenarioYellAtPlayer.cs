﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioYellAtPlayer : MonoBehaviour
{
    public string endtext;
    
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}

    private void OnTriggerEnter(Collider other) {
        //Debug.Log("Trigger entered by " + other.gameObject.name);
        if (other.gameObject.name == "VehicleCoords") {
            Debug.Log("Ending scenario for " + other.gameObject.name);
            other.GetComponent<VehicleScenario>().Update_Scenario(endtext);
            this.gameObject.SetActive(false);
        }
    }
}
