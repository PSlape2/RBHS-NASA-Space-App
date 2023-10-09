using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace MainMenu {
    public class MainMenuScript : MonoBehaviour {
        [SerializeField]
        public GameObject mainMenu, startObject, quitObject;
        [SerializeField]
        public GameObject selectSystemMenu, ourSunObject, otherSunObject, backObject1;
        [SerializeField]
        public GameObject selectPlanetMenu;

        private Button startButton, quitButton, ourSunButton, otherSunButton, backButton1;

        private Button venus, mars, jupiter, earth, uranus, neptune, back2, saturn, mercury;

        private GameObject dataStoragePrefab, dataStorage;

        private const float incDist = -1f;
        private const float endResult = -450f;

        // Start is called before the first frame update
        void Start() {
            mainMenu.SetActive(true);
            startButton = startObject.GetComponent<Button>();
            quitButton = quitObject.GetComponent<Button>();

            selectSystemMenu.SetActive(false);
            ourSunButton = ourSunObject.GetComponent<Button>();
            otherSunButton = otherSunObject.GetComponent<Button>();
            backButton1 = backObject1.GetComponent<Button>();

            
            venus = GameObject.Find("SelectPlanet/VenusButton").GetComponent<Button>();
            mars = GameObject.Find("SelectPlanet/MarsButton").GetComponent<Button>();
            jupiter = GameObject.Find("SelectPlanet/JupiterButton").GetComponent<Button>();
            earth = GameObject.Find("SelectPlanet/EarthButton").GetComponent<Button>();
            uranus = GameObject.Find("SelectPlanet/UranusButton").GetComponent<Button>();
            neptune = GameObject.Find("SelectPlanet/NeptuneButton").GetComponent<Button>();
            back2 = GameObject.Find("SelectPlanet/BackButton").GetComponent<Button>();
            saturn = GameObject.Find("SelectPlanet/SaturnButton").GetComponent<Button>();
            mercury = GameObject.Find("SelectPlanet/MercuryButton").GetComponent<Button>();
            
            selectPlanetMenu.SetActive(false);
            startButton.onClick.AddListener(playButtonAction);
            quitButton.onClick.AddListener(quitButtonAction);
            
            

            dataStoragePrefab = Resources.Load("Prefabs/DataStorage") as GameObject;
            
            if(dataStoragePrefab != null) {
                dataStorage = Instantiate(dataStoragePrefab, new Vector3(0,0,0), Quaternion.identity);
            } else {
                dataStorage = Instantiate(
                    Resources.Load("Prefabs/DataStorage") as GameObject,
                    new Vector3(0,0,0),
                    Quaternion.identity
                );
            }
            DontDestroyOnLoad(dataStorage);
        }
        public void playButtonAction() {
            mainMenu.SetActive(false);
            selectSystemMenu.SetActive(true);
            ourSunButton.onClick.AddListener(ourSunAction);
        }
        public void quitButtonAction() {
            Application.Quit();
        }
        public void loadSpaceView() {
            UnityEngine.SceneManagement.SceneManager.LoadScene("SpaceView");
        }
        public void backAction() {
            selectSystemMenu.SetActive(false);
            mainMenu.SetActive(true);
        }
        public void ourSunAction() {
            Debug.Log("Sun Selected");
            selectSystemMenu.SetActive(false);
            selectPlanetMenu.SetActive(true);
            venus.onClick.AddListener(venusAction);
            mars.onClick.AddListener(marsAction);
            jupiter.onClick.AddListener(jupiterAction);
            earth.onClick.AddListener(earthAction);
            uranus.onClick.AddListener(uranusAction);
            neptune.onClick.AddListener(neptuneAction);
            back2.onClick.AddListener(back2Action);
            saturn.onClick.AddListener(saturnAction);
            mercury.onClick.AddListener(mercuryAction);
        }
        public void venusAction() {
            Debug.Log("Ping");
            EventManager.TriggerEvent("Venus");
        }
        public void marsAction() {
            Debug.Log("Ping");
            EventManager.TriggerEvent("Mars");
        }
        public void jupiterAction() {
            Debug.Log("Ping");
            EventManager.TriggerEvent("Jupiter");
        }
        public void earthAction() {
            Debug.Log("Ping");
            EventManager.TriggerEvent("Earth");
        }
        public void uranusAction() {
            Debug.Log("Ping");
            EventManager.TriggerEvent("Uranus");
        }
        public void neptuneAction() {
            Debug.Log("Ping");
            EventManager.TriggerEvent("Neptune");
        }
        public void back2Action() {
            Debug.Log("Ping");
            selectPlanetMenu.SetActive(false);
            selectSystemMenu.SetActive(true);
        }
        public void saturnAction() {
            Debug.Log("Ping");
            EventManager.TriggerEvent("Saturn");
        }
        public void mercuryAction() {
            Debug.Log("Ping");
            EventManager.TriggerEvent("Mercury");
        }
    }
}