using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public class menu : MonoBehaviour {
    [MenuItem("SGAMenu/Clear PlayerPrefs")]
    private static void Clear_PlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
    }

    [MenuItem("SGAMenu/SubMenu/Select")]
    private static void subMenu_Selected()
    {
        Debug.Log("SubMenu 1 - selected");
    }

    //% 컨트롤
    //# 쉬프트
    //

    [MenuItem("SGAMenu/SubMenu/Hotkey Test %#v")]
    private static void subMenu_HotKey_1()
    {
        Debug.Log("HotKey Test : Ctrl + Shift + V");
    }

    [MenuItem("SGAMenu/SubMenu/Hotkey Test %#vg")]
    private static void subMenu_HotKey_2()
    {
        Debug.Log("HotKey Test : Ctrl + G");
    }

    [MenuItem("Assets/Load Selected Scene")]
    private static void LoadSelectedScene()
    {
        var selected = Selection.activeObject;
        if (Application.isPlaying)
        {
            EditorSceneManager.LoadScene(AssetDatabase.GetAssetPath(selected));
        }
        else
        {
            EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(selected));
        }
    }

    //Ctrl + Shift + L
    [MenuItem("SGAMenu/SubMenu/Load Selected Scene %#L")]
    private static void LoadSelectedScene_HotKey()
    {
        Debug.Log("HotKey Test: CTRL SHIFT L");
        var selected = Selection.activeObject;
        if (Application.isPlaying)
        {
            EditorSceneManager.LoadScene(AssetDatabase.GetAssetPath(selected));
        }
        else
        {
            EditorSceneManager.OpenScene(AssetDatabase.GetAssetPath(selected));
        }
    }
}
