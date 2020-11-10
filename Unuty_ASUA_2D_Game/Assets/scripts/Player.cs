using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //欄位:儲存資料
    public GameObject final;

    //道具數量文字
    public Text textCount;
    //數量
    public int count;

    private void OnTriggerEnter2D(Collider2D collision)
    //碰撞偵測條件
    //1.兩者物件必須皆有碰撞器 collider2D 
    //2.兩者其一需有一個剛體 Rigidboby2D 
    // collision 儲存碰到物件的資訊
    {
        //if(條件){條件成立時會執行的程式區塊}
        //如碰到物件名稱為傳送門...
      
        if (collision.name=="傳送門")
        {
           final.SetActive(true);      //啟動設定(是)
        }
        //如果碰到鑽石就吃掉(鑽石會消失)
        if (collision.tag=="鑽石")
        {
            Destroy(collision.gameObject);
            //遞增
            count++;
            //道具數量的文字="鑽石數量:"+數量
            textCount.text = "鑽石數量:" + count;
        }
    }

}
