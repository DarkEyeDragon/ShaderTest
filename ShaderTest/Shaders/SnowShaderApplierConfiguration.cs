using Bindito.Core;
using TimberApi.ConfiguratorSystem;
using TimberApi.SceneSystem;
using TimberApi.ShaderSystem;

namespace ShaderTest.Shaders;

[Configurator(SceneEntrypoint.InGame)]
public class SnowShaderApplierConfiguration : IConfigurator
{
    public void Configure(IContainerDefinition containerDefinition)
    {
        containerDefinition.MultiBind<IShaderApplier>().To<SnowShaderApplier>().AsSingleton();
    }
}