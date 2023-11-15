using MixedReality.Toolkit;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.Rendering.DebugUI.Table;

public class TextureChanger: MonoBehaviour
{  
    public GameObject cube;
    public Texture[] textures;

    public Renderer cubeRenderer;
    public Renderer cubeRenderer2;
    public int randomTextureIndex;

    public void Start()
    {
        
        StatefulInteractable statefulInteractable = gameObject.AddComponent<StatefulInteractable>();
        statefulInteractable.OnClicked.AddListener(ChangeCubeTexture);
        cubeRenderer = cube.GetComponent<Renderer>();
        cubeRenderer2 = cube.GetComponent<Renderer>();
    }

    public void ChangeCubeTexture()
    {
        randomTextureIndex = Random.Range(0, textures.Length);
        Debug.Log("clicked");
        if (cubeRenderer != null && textures.Length > 0 && cubeRenderer2!=null)
        {
            cubeRenderer.material.mainTexture = textures[randomTextureIndex];
            cubeRenderer2.material.mainTexture = textures[randomTextureIndex];
        }
        else
        {
            Debug.LogError("Cube Renderer not found or textures array is empty!");
        }
    }
}







        

