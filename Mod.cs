using Colossal.Logging;
using Colossal.UI;
using Game;
using Game.Modding;
using Game.SceneFlow;
using System.IO;

namespace MiniTrackServices
{
    public class Mod : IMod
    {
        public static string Name = "Mini Track Services";
        public static string Version = "1.0.0";
        public static string Author = "StarQ";
        //public static ILog log = LogManager.GetLogger($"{nameof(MiniTrackServices)}").SetShowsErrorsInUI(false);

        public static string uiHostName = "starq-minitrackservices";

        public void OnLoad(UpdateSystem updateSystem)
        {
            GameManager.instance.modManager.TryGetExecutableAsset(this, out var asset);
            UIManager.defaultUISystem.AddHostLocation(uiHostName, Path.Combine(Path.GetDirectoryName(asset.path), "thumbs"), false);
        }
        
        public void OnDispose()
        {
            UIManager.defaultUISystem.RemoveHostLocation(uiHostName);
        }
    }
}