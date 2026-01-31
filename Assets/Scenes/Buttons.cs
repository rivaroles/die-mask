using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
  
  public void GoToSceneGame(){

    SceneManager.LoadScene("Gameplay");
  }

public void QuitGame(){

   Application.Quit();

}

}
