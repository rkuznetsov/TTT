using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
    public static readonly int X = 1;
    public static readonly int O = 2;

    public static GameManager instance { get; private set; }

    public UIButton[] cellsButton;
    public int currentPlayer = 1;

    private int[,] fieldArr = new int[3, 3];

    void Awake()
    {
        instance = this;
    }

    public void SetFieldArrElement(int x, int y, int type)
    {
        fieldArr[x, y] = type;    
    }	

	void Update ()
    {

        DeadHeat();

        for (int i = 0; i < 3; i++) 
        {
            if (fieldArr[i, 0] == fieldArr[i, 1] && fieldArr[i, 1] == fieldArr[i, 2] && fieldArr[i, 2] != 0) 
            {              
                GameOver.instance.CompleteHorizontalLine(i);
                VictoryWindow.instance.ShowVictoryWindow(fieldArr[i, 0]);
            }
            if (fieldArr[0, i] == fieldArr[1, i] && fieldArr[1, i] == fieldArr[2, i] && fieldArr[2,i] != 0)
            {                        
                GameOver.instance.CompleteVerticalLine(i);
                VictoryWindow.instance.ShowVictoryWindow(fieldArr[0, i]);
            }
        }

        if (fieldArr[0, 0] == fieldArr[1, 1] && fieldArr[1, 1] == fieldArr[2, 2] && fieldArr[2, 2] != 0)
        {
            GameOver.instance.CompleteDiagonal(0);
            VictoryWindow.instance.ShowVictoryWindow(fieldArr[0, 0]);
        }
        if (fieldArr[0, 2] == fieldArr[1, 1] && fieldArr[1, 1] == fieldArr[2, 0] && fieldArr[2, 0] != 0)
        {
            GameOver.instance.CompleteDiagonal(1);
            VictoryWindow.instance.ShowVictoryWindow(fieldArr[0, 2]);
        }    
     }

    private void DeadHeat()
    {
        int deadHeat = 0;

        foreach (UIButton btn in cellsButton)
        {
            if (NGUITools.GetActive(btn.gameObject) == false)
            {
                deadHeat += 1;
            }
        }

        if (deadHeat == 9)
        {
            VictoryWindow.instance.ShowDeadHeat();        
        }
    }


}
