using UnityEngine;
using UnityEditor; // エディタ拡張関連はUnityEditor名前空間に定義されているのでusingしておく。
using System.Collections;

// エディタに独自のウィンドウを作成する
public class EditorExWindow : EditorWindow
{
    // メニューのWindowにEditorExという項目を追加。
    [MenuItem("Window/EditorEx")]
    static void Open()
    {
        // メニューのWindow/EditorExを選択するとOpen()が呼ばれる。
        // 表示させたいウィンドウは基本的にGetWindow()で表示＆取得する。
		EditorWindow.GetWindow<EditorExWindow>("EditorEx"); // タイトル名を"EditorEx"に指定（後からでも変えられるけど）
    }

    Object objectField = null;
    Color colorField = Color.white;

    private GameObject myCube;

    // Windowのクライアント領域のGUI処理を記述
    void OnGUI()
    {
        // 試しにラベルを表示
        EditorGUILayout.LabelField("あああ");
        colorField = EditorGUILayout.ColorField("ColorField", colorField);
        objectField = EditorGUILayout.ObjectField("モデルデータ", myCube, typeof(Object), true);
}

    void Update()
    {
        //myCube = GameObject.Find("car");
        if(objectField != null) { Debug.Log(myCube); }
    }
}