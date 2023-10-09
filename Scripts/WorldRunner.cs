using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Planets;

public class WorldRunner : MonoBehaviour {
    string type;
    private PlanetRunner pr;
    // Start is called before the first frame update
    void Start() {
        // pr = new PlanetRunner(main, bmp, material, planet);
        type = GameObject.FindWithTag("Data").GetComponent<DataStorageScript>().ActivePlanet;
        if(type != null) {
             GameObject.FindWithTag("Data").GetComponent<DataStorageScript>().ActivePlanet = "Earth";
        } else {
            pr = new PlanetRunner();
        }
        pr = new PlanetRunner(type);    
    }
    // Update is called once per frame
    void Update() {
        // pr.onUpdate();
    }
}
