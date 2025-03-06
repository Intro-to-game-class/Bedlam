using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Inventory))]
[CanEditMultipleObjects]


public class InventoryEditor : Editor
{
    SerializedProperty inventoryUI;
    SerializedProperty items;
    SerializedProperty quantities;
    void OnEnable()
    {
        inventoryUI = serializedObject.FindProperty("inventoryPanel");
        items = serializedObject.FindProperty("itemList");
        quantities = serializedObject.FindProperty("quantityList");
    }

    public override void OnInspectorGUI()
    {
        EditorGUILayout.LabelField("Place the parent object of the Inventory Slots here:");
        serializedObject.Update();
        EditorGUILayout.PropertyField(inventoryUI);
        serializedObject.ApplyModifiedProperties();

        serializedObject.Update();

        // Ensure both lists have the same size
        int listSize = Mathf.Min(items.arraySize, quantities.arraySize);

        for (int i = 0; i < listSize; i++)
        {
            EditorGUILayout.BeginHorizontal();

            // Display item
            EditorGUILayout.PropertyField(items.GetArrayElementAtIndex(i), GUIContent.none, true, GUILayout.MinWidth(100));

            // Display quantity
            EditorGUILayout.PropertyField(quantities.GetArrayElementAtIndex(i), GUIContent.none, true, GUILayout.MinWidth(50));

            EditorGUILayout.EndHorizontal();
        }

        serializedObject.ApplyModifiedProperties();
    }
}
