using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace ImmerzaSDK.Types
{
    public class SceneMetadata
    {
        [JsonProperty("platforms")]
        public List<PlatformInfo> platforms = new();
        [JsonProperty("sdk_version")]
        public string sdkVersion;
        [JsonProperty("is_using_bg_music")]
        public bool isUsingBgMusic;

        [JsonProperty("asset_metadata")]
        public AssetMetadata assetMetaData;

        public void SaveMetaData(string fielPath)
        {
            string jsonContent = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(fielPath, jsonContent);
        }
    }

    public class PlatformInfo
    {
        public PlatformInfo(string platformId, uint hash) 
        { 
            this.platformId = platformId;
            this.hash = hash;
        }

        [JsonProperty("platform_id")]
        public string platformId;
        [JsonProperty("file_id")]
        public string fileId = "0";
        [JsonProperty("hash")]
        public uint hash;
    }
}
