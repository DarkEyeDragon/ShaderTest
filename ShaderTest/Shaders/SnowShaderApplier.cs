using TimberApi.AssetSystem;
using TimberApi.ShaderSystem;
using UnityEngine;

namespace ShaderTest.Shaders;

public class SnowShaderApplier : IShaderApplier
{
    private Shader? _snowShader;
    private IAssetLoader _assetLoader;

    public SnowShaderApplier(IAssetLoader assetLoader)
    {
        ShaderTest.ConsoleWriter.LogInfo("SnowShaderApplier#Constructor called");
        _assetLoader = assetLoader;
    }

    public void LoadShader()
    {
        //_snowShader = _assetLoader.Load<Shader>($"{TexturePathTypes.Season}/Shaders/SnowLayers");
    }

    public bool ShouldApplyShader(Material material)
    {
        ShaderTest.ConsoleWriter.LogInfo("SnowShaderApplier#ShouldApplyShader called");
        return material.name.StartsWith("Grass") && !material.name.StartsWith("CliffEdge");
        //return false;
    }

    public void Apply(Material material)
    {
        //var shader = material.shader = _snowShader;
        /*int count = shader.GetPropertyCount();
        for (int i = 0; i < count; i++)
        {
            SeasonsPlugin.ConsoleWriter.LogInfo($"Shader property: {shader.GetPropertyName(i)}");
        }*/
    }
}