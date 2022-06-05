using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;



public class Game_page_click : MonoBehaviour
{

    public void scenchange()
    {


         SceneManager.LoadScene("01-2.GameSetting");

    }

     public void page_back()
     {

          SceneManager.LoadScene("01-1.StartPage");

     }
     
     public void GameQuit()
     {
          Application.Quit();
     }

/* public void Restaret(){

SceneManagement.LoadScene("01-2.GameSetting")

}
 */
 public void scenchange_Again()
    {

         SceneManager.LoadScene("02-1.GameScene");

    }








     /* public void onmouseEnter()
     {
          onmouseEnter; 
     }

   public void OnPointerEnter(PointerEventData eventData)
    {
        if(!IsEmpty)
        {
            UIManager.MyInstance.ShowTooltip();
        }
    }
 
    // 마우스 커서가 Slot 영역 안에서 밖으로 나가면 호출
    public void OnPointerExit(PointerEventData eventData)
    {
        UIManager.MyInstance.HideTooltip();
    }
 */



 
}
  

