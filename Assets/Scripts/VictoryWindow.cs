using UnityEngine;
using System.Collections;

public class VictoryWindow : MonoBehaviour {

    public static VictoryWindow instance { get; private set; }

    public GameObject window;
    public GameObject windowDeadHeat;
    public GameObject x;
    public GameObject o;

    void Awake()
    {
        instance = this;
    }

   public void ShowVictoryWindow(int player)
    {
        if (player == GameManager.X)
        {
            x.gameObject.SetActive(true);
            window.gameObject.SetActive(true);
        }
        else if (player == GameManager.O)
        {
            o.gameObject.SetActive(true);
            window.gameObject.SetActive(true);
        }

        if (NGUITools.GetActive(windowDeadHeat))
        {
            windowDeadHeat.SetActive(false);
        }
    }

   public void ShowDeadHeat()
   {
       windowDeadHeat.gameObject.SetActive(true);
   }

   public void RestartGame()
   {
       Application.LoadLevel(Application.loadedLevel);   
   }	
}
