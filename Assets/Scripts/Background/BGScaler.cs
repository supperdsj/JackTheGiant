using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Vector3 tempScale = transform.localScale;
        // Vector3 tempLocation = transform.localPosition;

        float width = sr.sprite.bounds.size.x;

        float worldHeight = Camera.main.orthographicSize * 2.0f;
        float worldWidth = worldHeight / Screen.height * Screen.width;

        tempScale.x = worldWidth / width;
        tempScale.y = tempScale.x;
        transform.localScale = tempScale;

        // tempLocation.y = 0;
        // tempLocation.x = -width / 2;
        // transform.localPosition = tempLocation;
    }
}
