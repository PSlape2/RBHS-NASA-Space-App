using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
The Scrolling class is deprecated. Functions are provided in MainMenuScript.cs
*/
public class Scrolling : MonoBehaviour {
    RectTransform text;
    private int counter, maxCount;
    Vector2 curPos, targetPos;
    bool start;
    private float distance;

    private const float incDist = -1f;
    private const float endResult = -450;

        // Start is called before the first frame update
    void Start() {
        text = GetComponent<RectTransform>();
        distance = calculateDistance();
        maxCount = Mathf.Abs((int) distance / (int) incDist);
        counter = 0;
    }
    private float calculateDistance() {
        if(text.anchoredPosition.y > endResult) {
            return text.anchoredPosition.y - endResult;
        } else {
            return endResult - text.anchoredPosition.y;
        }
    }

        // Update is called once per frame
    void Update() {
        if(start) {
            if(counter < maxCount) {
                curPos = text.anchoredPosition;
                targetPos = new Vector2(curPos.x, curPos.y + incDist);
                text.anchoredPosition = targetPos;
            }
        }
    }

    public void startScroll() {
        start = true;
    }
    public bool hasReached() {
        return text.anchoredPosition.y == endResult;
    }
}
