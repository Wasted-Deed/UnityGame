using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameControllerScript : MonoBehaviour
{
  public void MenuPressed()
  {
     SceneManager.LoadScene(0);
  }
  
}

