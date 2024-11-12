using UnityEngine;
using TMPro;

public class HelloWorldManager : MonoBehaviour
{
    private TextMeshPro textMesh;

    void Start()
    {
        // 创建3D文本
        GameObject textObject = new GameObject("HelloWorld");
        textMesh = textObject.AddComponent<TextMeshPro>();
        
        // 设置文本内容和属性
        textMesh.text = "Hello World";
        textMesh.fontSize = 10;
        textMesh.alignment = TextAlignmentOptions.Center;
        
        // 设置位置
        textObject.transform.position = new Vector3(0, 1.7f, 3f);
        textObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        
        // 设置文本大小
        textObject.transform.localScale = new Vector3(1, 1, 1);
    }
} 