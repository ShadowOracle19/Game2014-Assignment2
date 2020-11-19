using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayButtonBehvaiour : MonoBehaviour
{
    
    public void onButtonClick()
    {
        SceneManager.LoadScene("Game");
    }
}
