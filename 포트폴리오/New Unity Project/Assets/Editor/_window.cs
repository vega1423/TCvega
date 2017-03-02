//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//using UnityEditor;



//public class _window : EditorWindow{

//    string[] cheatLost = new string[] {
//        "치트",
//        "골드 생성",
//        "포인트 생성",
//    };

//    static int selectedIndex = 0;

//    int getInt = 0;
//    string getString = "";

//    [MenuItem("SGAMenu/SubMenu/치트명령창")]
//    static public void OpenCheatWindow()
//    {
//        Debug.Log("치트 명령창");
//    }

//    [MenuItem("SGAMenu/SubMenu/치트명령창", false, 0)]
//    static public void OpenCheatWindow1()
//    {
//        _window getWindow = EditorWindow.GetWindow<_window>(
//            false,
//            "Cheat Window", 
//            true);


//    }

//    [MenuItem("SGAMenu/SubMenu/치트명령창2", true, 0)]
//    static public void OpenCheatWindow2()
//    {
//        _window getWindow = EditorWindow.GetWindow<_window>(
//            false,
//            "Cheat Window",
//            true);
//    }


//    // Use this for initialization
//    void Start () {
		
//	}
	
//	// Update is called once per frame
//	void Update () {
		
//	}

//    private void OnGUI()
//    {
//        GUILayout.Space(10.0f);

//        int getIndex = EditorGUILayout.Popup(selectedIndex, cheatLost, GUILayout.MaxWidth(200.0f));

//        if (selectedIndex != getIndex)
//        {
//            selectedIndex = getIndex;
//        }






//        GUILayout.Space(20.0f);
//        GUILayout.BeginHorizontal(GUILayout.MaxWidth(800.0f));

//        GUILayout.BeginVertical(GUILayout.MaxWidth(300.0f));

//        GUILayout.BeginHorizontal(GUILayout.MaxWidth(300.0f));

//        if(GUILayout.Button("\n적용\n"))
//    }
//}
