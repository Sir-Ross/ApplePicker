using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class QuitGame{

    public static void Quit() {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}