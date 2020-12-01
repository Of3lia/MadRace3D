using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void GoToLevel()
    {
        SceneManager.LoadScene(1);
    }
}
