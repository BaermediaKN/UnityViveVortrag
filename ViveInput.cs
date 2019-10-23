using UnityEngine;
using Valve.VR;         // Für die SteamVR Funktionen

public class ViveInput : MonoBehaviour
{

    void Update()
     {
         // Drücken der Touchpads
         if (SteamVR_Actions._default.Teleport.GetStateDown(SteamVR_Input_Sources.LeftHand))    //SteamVR_Actions Zugriff auf die Actions
                                                                                                // _default ist unser Actionset
                                                                                                // Greife auf die Action Teleport zu
                                                                                                // GetStateDown, wenn ein entsprechender Button gedrückt wird
                                                                                                // SteamVR_Input_Sources.LeftHand beobachtet dabei alle Buttons des linken Controllers
         {
             print("Left Touchpad Clicked");
             // Füge Code ein der ausgeführt werden soll, wenn linkes Touchpad gedrückt wird
         }

         if (SteamVR_Actions._default.Teleport.GetStateDown(SteamVR_Input_Sources.RightHand))
         {
             print("Left Touchpad Clicked");
             // Füge Code ein der ausgeführt werden soll, wenn rechtes Touchpad gedrückt wird
         }

        // Touchpad Berührung
         Vector2 touchpoint = SteamVR_Actions._default.Touch.GetAxis(SteamVR_Input_Sources.Any);    // Erhält Werte (-1:1, -1:1) 1. Wert Horizontal, 2. Vertikal
         if(touchpoint != Vector2.zero)
         {
             print(touchpoint);
             // Führe Code aus, z.B. Bewegung
         }        
     }
}



