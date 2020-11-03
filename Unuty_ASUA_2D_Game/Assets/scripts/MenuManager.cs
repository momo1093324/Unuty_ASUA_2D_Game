using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
//按鈕如何與程式溝通
//加入public使其公開，讓按鈕能與程式連結 
public void StartGame() 
    {
        print("開始遊戲");
        SceneManager.LoadScene("關卡1");
        //另一種的語法方式 SceneManager.LoadScene(1);
        //皆指場景連結，可從選單進入關卡1；另外需把介面與關卡拉入unity build setting
    }
  public void QuitGame()
    {
        print("結束遊戲");
        Application.Quit();    //遊戲退出，需發佈才會出現
    }
}
