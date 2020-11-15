using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   // 註解：說明
   //按鈕如何跟城市溝通
   //需要：方法(函式 功能) - 一堆有功能的程式，演算法
   //語法：
   //類型 方法名稱 ( ) { }
   // void 無類型
   public void StartGame ()
    {
        print("開始遊戲");
        SceneManager.LoadScene("關卡1");
    }
   
    public void QuitGame()
    {
        print("離開遊戲");
        Application.Quit();
    }
}
