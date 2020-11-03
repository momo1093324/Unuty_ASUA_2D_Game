using UnityEngine;

public class Player : MonoBehaviour
{
    //欄位:儲存資料
    public GameObject final1;

    private void OnTriggerEnter2D(Collider2D collision)
        //碰撞偵測條件
        //1.兩者物件必須皆有碰撞器 collider2D  2.兩者其一需有一個剛體 Rigidboby2D 
    {
        print("遇到傳送奇遇時間");
        final1.SetActive(true);      //啟動設定(是)
    }

}
