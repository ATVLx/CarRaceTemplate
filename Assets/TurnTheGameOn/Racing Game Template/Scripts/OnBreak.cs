using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class OnBreak : MonoBehaviour,IPointerDownHandler, IPointerUpHandler {
    bool pointerdown = false;
	// Use this for initialization
	void Start () {
		
	}

// Update is called once per frame
void Update()
{

}
    public void OnPointerDown(PointerEventData data)
    {
        pointerdown = true;
    }
    public void OnPointerUp(PointerEventData data)
    {
        pointerdown = false;
    }

    public float breeak(){
        float brak;
        if (pointerdown == true) {
            brak = -1;
        }
        else {
            brak = 0;

        }
        return brak;
    }
}
