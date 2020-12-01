using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelUI : MonoBehaviour
{
    [SerializeField] private Text speedText;
    [SerializeField] private Player player;

    private void FixedUpdate()
    {
        speedText.text = "SPEED: " + ((int)player.speed).ToString() + " km/h";
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
