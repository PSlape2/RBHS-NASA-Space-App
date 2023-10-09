using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour {

    [SerializeField]
    public GameObject canvas;
    
    private string type;
    private GameObject panel, restartObj, openObj, closeObj,dataObj;
    private Sprite image;
    private Button restartButton, closePanel, openPanel;
    private Image data;
    // Start is called before the first frame update
    void Start() {
        type = GameObject.FindWithTag("Data").GetComponent<DataStorageScript>().ActivePlanet;

        restartObj = GameObject.Find("UICanvas/RestartButton");
        openObj = GameObject.Find("UICanvas/OpenPanelButton");
        closeObj = GameObject.Find("UICanvas/InfoPanel/BackButton");
        dataObj = GameObject.Find("UICanvas/InfoPanel/Image");

        restartButton = restartObj.GetComponent<Button>();
        openPanel = openObj.GetComponent<Button>();
        closePanel = closeObj.GetComponent<Button>();
        data = dataObj.GetComponent<Image>();

       // image = Resources.Load<Sprite>("Texture/Data/" + type);

        panel = GameObject.Find("UICanvas/InfoPanel");
        data.overrideSprite = image;
        panel.SetActive(false);

        openPanel.onClick.AddListener(onOpenPanelButton);
        restartButton.onClick.AddListener(onRestartButton);
    }

    private void onRestartButton() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
    private void onOpenPanelButton() {
        panel.SetActive(true);
        openObj.SetActive(false);
        closePanel.onClick.AddListener(onClosePanelButton);
    }
    private void onClosePanelButton() {
        panel.SetActive(false);
        openObj.SetActive(true);
        openPanel.onClick.AddListener(onOpenPanelButton);
    }
}
