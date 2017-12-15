using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_exit : MonoBehaviour
{
    public GameObject startUI, restartUI, instructionUI;
    public GameObject closebutton_HostageUI, closebutton_MedUI, closebutton_ShootUI, closebutton_BombUI;

    // Use this for initialization
    void Start() { }

    public void closebuttonHostage()
        //Use to close a panel through buttons
    {
        closebutton_HostageUI.SetActive(false);
    }
    public void closebuttonMed()
    //Use to close a panel through buttons
    {
        closebutton_MedUI.SetActive(false);
    }
    public void closebuttonShoot()
    //Use to close a panel through buttons
    {
        closebutton_ShootUI.SetActive(false);
    }

    public void closebuttonBomb()
    //Use to close a panel through buttons
    {
        closebutton_BombUI.SetActive(false);
    }

    // Begin the sequence.
    public void StartMuseum()
    {  // Enable the start UI.
        startUI.SetActive(false);
        instructionUI.SetActive(true);
    }

    public void BeginTour()
    {
        instructionUI.SetActive(false);

    }    
    public void exitbutton ()
    { 
       // Disable the start UI.
       startUI.SetActive(false);


    }

    

    // Update is called once per frame
    public void Exit()
    {
        {
            Debug.Log("Saliendo");
            Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

        }
        
    }
}

