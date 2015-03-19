using UnityEngine;
using System.Collections;

public class Cell : MonoBehaviour
{
    public GameObject cell;
    public GameObject button;
    public GameObject x;
    public GameObject o;

    public int posX, posY; 

    public void CellButton()     
    {

        cell.GetComponentInChildren<UIButton>().gameObject.SetActive(false);

        if (GameManager.instance.currentPlayer == 1)
        {
            x.SetActive(true);

            GameManager.instance.SetFieldArrElement(posX,posY, GameManager.X);
            GameManager.instance.currentPlayer = 2;
        }
        else 
        {           
            o.SetActive(true);

            GameManager.instance.SetFieldArrElement(posX, posY, GameManager.O);
            GameManager.instance.currentPlayer = 1;
        }    
    }
}
