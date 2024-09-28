using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickChecker : MonoBehaviour , IPointerClickHandler
{
 	Image image;

	void Start(){
		image = gameObject.GetComponent<Image>();
	}
	
	public void OnPointerClick(PointerEventData pointerData){
		Debug.Log(gameObject.name + " がクリックされた!");
		
	}

}