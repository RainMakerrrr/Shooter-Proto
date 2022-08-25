using UnityEngine;

namespace Code.Infrastructure.Services.Assets
{
    public class AssetProvider : IAssetProvider
    {
        public T Load<T>(string path) where T : Object => Resources.Load<T>(path);

        public T[] LoadCollection<T>(string path) where T : Object => Resources.LoadAll<T>(path);

        public void Clear() => Resources.UnloadUnusedAssets();
    }
}