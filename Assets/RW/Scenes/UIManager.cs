using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public Animator startButton;
public Animator settingsButton;
public class UIManager : MonoBehaviour
public Animator startButton;
public Animator settingsButton;
{
  public void StartGame() 
{
    SceneManager.LoadScene("RocketMouse");
}
public void OpenSettings() 
{
    startButton.SetBool("isHidden", true);
    settingsButton.SetBool("isHidden", true);
}
}
