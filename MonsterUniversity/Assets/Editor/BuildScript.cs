using UnityEditor;

public class BuildScript
{
    static string[] scenes = { "Assets/Scenes/MainScene.unity" };

    [MenuItem("Build/WebGL")]
    public static void BuildWebGL()
    {
        BuildPipeline.BuildPlayer(
            scenes,
            "Build/WebGL",
            BuildTarget.WebGL,
            BuildOptions.None
        );
    }
}
