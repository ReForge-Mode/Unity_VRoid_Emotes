using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapTextureManager : MonoBehaviour
{
    /// <summary>
    /// This is a method on getting an instantiated version of materials.
    /// You can modify any properties inside this instantiated version
    /// without affecting the original material.
    /// So, you can have different objects sharing the same material,
    /// with different states.
    /// 
    /// The big downside is that when you create an instance, it does cost some memory
    /// If you just want to edit one material inside a Renderer, 
    /// consider using MaterialPropertyBlock instead. 
    /// </summary>

    [Header("References")]
    [SerializeField] private Renderer _renderer;
    [SerializeField] private List<Texture> _textureSwapList;
    private List<Material> _materialList;

    private void Awake()
    {
        //Get an instanced material from the Renderer
        _materialList = new List<Material>();
        _renderer.GetMaterials(_materialList);
    }

    /// <summary>
    /// Swap Texture 2 to the next texture to transition to.
    /// </summary>
    /// <param name="indexTo">The index of the texture in _textureSwapList</param>
    public void SwapTexture(int indexTo)
    {
        //Swap Texture 2 as the next Texture to transition to
        _materialList[7].SetTexture("_MainTex2", _textureSwapList[indexTo]);
        _materialList[8].SetTexture("_MainTex2", _textureSwapList[indexTo]);
        _materialList[7].SetTexture("_ShadeTex2", _textureSwapList[indexTo]);
        _materialList[8].SetTexture("_ShadeTex2", _textureSwapList[indexTo]);
    }

    private void OnDestroy()
    {
        //Clear the memory manually for every instanced material.
        //This is crucial, because Unity won't delete it automatically.
        foreach (var mat in _materialList)
        {
            Destroy(mat);
        }
    }
}