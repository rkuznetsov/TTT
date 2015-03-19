using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    public static GameOver instance {get; private set;}

    public GameObject line1;
    public GameObject line2;
    public GameObject line3;
    public GameObject line4;
    
    void Awake()
    {
        instance = this;
    }

    public void CompleteVerticalLine(int lineNumber)
    {
        if (lineNumber == 0) 
        {
            ShowGameOverLine(1);
        }
        else if (lineNumber == 1) 
        {
            ShowGameOverLine(2);
        }
        else if (lineNumber == 2)
        {
            ShowGameOverLine(3);
        }    
    }

    public void CompleteHorizontalLine(int lineNumber)
    {
        if (lineNumber == 0)
        {
            ShowGameOverLine(4);
        }
        else if (lineNumber == 1)
        {
            ShowGameOverLine(5);
        }
        else if (lineNumber == 2)
        {
            ShowGameOverLine(6);
        }    
    }

    public void CompleteDiagonal(int diagonalNumber)
    {
        if (diagonalNumber == 0)
        {
            ShowGameOverLine(7);
        }
        else if (diagonalNumber == 1)
        {
            ShowGameOverLine(8);        
        }    
    }

    private void ShowGameOverLine(int lineNumber)
    {
        switch (lineNumber)
        {
            case 1:
                line1.transform.localPosition = new Vector3(-200,0,0);
                line1.SetActive(true);
                break;
            case 2:
                line1.transform.localPosition = new Vector3(0,0,0);
                line1.SetActive(true);
                break;
            case 3:
                line1.transform.localPosition = new Vector3(200,0,0);
                line1.SetActive(true);
                break;
            case 4:
                line2.transform.localPosition = new Vector3(0,200,0);
                line2.SetActive(true);
                break;
            case 5:
                line2.transform.localPosition = new Vector3(0,0.5f,0);
                line2.SetActive(true);
                break;
            case 6:
                line2.transform.localPosition = new Vector3(0,-200,0);
                line2.SetActive(true);
                break;
            case 7:
                line3.gameObject.SetActive(true);
                break;
            case 8:
                line4.gameObject.SetActive(true);
                break;
        }    
    }
}
