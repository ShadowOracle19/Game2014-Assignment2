using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public void onButtonClick()
    {
        SceneManager.LoadScene("Menu");
    }
}
