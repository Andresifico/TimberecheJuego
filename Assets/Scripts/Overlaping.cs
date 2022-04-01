using UnityEngine;
 using UnityEngine.UI;
 using UnityEngine.EventSystems;
 using System.Collections.Generic;
 
 
 public class Overlaping: MonoBehaviour 
 {
     private GraphicRaycaster raycaster;
 
     private PointerEventData pointerEventData;
 
     private EventSystem eventSystem;
 
 
     void Start()
     {
         raycaster = GetComponent<GraphicRaycaster>();
 
         eventSystem = GetComponent<EventSystem>();
     }
 
 
     void Update()
     {
         if (Input.GetKeyUp(KeyCode.Mouse0))
         {
             pointerEventData = new PointerEventData(eventSystem);
             pointerEventData.position = Input.mousePosition;
 
             List<RaycastResult> results = new List<RaycastResult>();
 
             raycaster.Raycast(pointerEventData, results);
 
 
             bool firstTargetIgnored = false;
 
             foreach (RaycastResult result in results)
             {
 // Ignore the first target with raycastTarget as this will receive the normal click event trigger
 // This prevents the first raycastTarget being invoked twice
                 if (firstTargetIgnored)
                 {
                     if (result.gameObject.GetComponent<GameObject>())
                     {
                         Debug.Log("INVOKED:" + result.gameObject.name);
 
                         result.gameObject.GetComponent<Button>().onClick.Invoke();
                     }
                 }
 
 
                 if ( ! firstTargetIgnored)
                 {
                     firstTargetIgnored = true;
                 }
             }
         }
     }
 }
