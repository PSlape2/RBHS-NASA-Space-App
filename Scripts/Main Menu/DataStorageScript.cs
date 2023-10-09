using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MainMenu;

public class DataStorageScript : MonoBehaviour {

    private string activePlanet;

    // Start is called before the first frame update
    void Start() {
        Debug.Log("Data Storage Initialized");
        EventManager.StartListening("Venus", onVenus);
        EventManager.StartListening("Mars", onMars);
        EventManager.StartListening("Jupiter", onJupiter);
        EventManager.StartListening("Earth", onEarth);
        EventManager.StartListening("Uranus", onUranus);
        EventManager.StartListening("Neptune", onNeptune);
        EventManager.StartListening("Saturn", onSaturn);
        EventManager.StartListening("Mercury", onMercury);
    }
    void onSceneLoaded() {
        Debug.Log(activePlanet);
    }
    
    public string ActivePlanet 
    {
        get { return activePlanet; }
        set { activePlanet = value; }
    }
    
    private void onVenus() {
        Debug.Log("Pong - Venus 2");
        activePlanet = "Venus";
        loadSpaceView();
    }
    private void onMars() {
        Debug.Log("Pong - Mars 2");
        activePlanet = "Mars";
        loadSpaceView();
    }
    private void onJupiter() {
        Debug.Log("Pong - Jupiter 2");
        activePlanet = "Jupiter";
        loadSpaceView();
    }
    private void onEarth() {
        Debug.Log("Pong - Earth 2");
        activePlanet = "Earth";
        loadSpaceView();
    }
    private void onUranus() {
        Debug.Log("Pong - Uranus 2");
        activePlanet = "Uranus";
        loadSpaceView();
    }
    private void onNeptune() {
        Debug.Log("Pong - Neptune 2");
        activePlanet = "Neptune";
        loadSpaceView();
    }
    private void onSaturn() {
        Debug.Log("Pong - Saturn 2");
        activePlanet = "Saturn";
        loadSpaceView();
    }
    private void onMercury() {
        Debug.Log("Pong - Mercury 2");
        activePlanet = "Mercury";
        loadSpaceView();
    }

    public void loadSpaceView() {
        Debug.Log("Changing Scenes");
        UnityEngine.SceneManagement.SceneManager.LoadScene("SpaceView");
    }
}
