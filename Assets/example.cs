using UnityEngine;
using System.Collections;

public class example : MonoBehaviour
{
    // マウスボタンが押された時にコールされる
    void OnMouseDown()
    {
        print("MouseDown!");
    }

    // マウスボタンを離した時にコールされる
    void OnMouseUp()
    {
        print("MouseUp!");
    }

    // マウスカーソルが対象オブジェクトから退出した時にコールされる
    void OnMouseExit()
    {
        print("MouseExit!");
    }

    // マウスカーソルが対象オブジェクトに進入した時にコールされる
    void OnMouseEnter()
    {
        print("MouseEnter!");
    }

    // マウスカーソルが対象オブジェクトに重なっている間コールされ続ける
    void OnMouseOver()
    {
        print("MouseOver!");
    }

    // マウスボタンが押された状態でマウスを移動させてる間コールされ続ける
    void OnMouseDrag()
    {
        print("MouseDrag!");
    }
}