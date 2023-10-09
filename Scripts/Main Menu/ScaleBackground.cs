using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class ScaleBackground : MonoBehaviour {
    Image bgImage;
    RectTransform rt;
    float ratio;
    
    // Start is called before the first frame update
    void Start() {
        bgImage = GetComponent<Image>();
        rt = bgImage.rectTransform;
        ratio = bgImage.sprite.bounds.size.x / bgImage.sprite.bounds.size.y;
    }

    // Update is called once per frame
    void Update() {
        if(!rt) return;

        if(Screen.height * ratio >= Screen.width) {
            rt.sizeDelta = new Vector2(Screen.height * ratio, Screen.height);
        } else {
            rt.sizeDelta = new Vector2(Screen.width, Screen.width / ratio);
        }
    }
}
