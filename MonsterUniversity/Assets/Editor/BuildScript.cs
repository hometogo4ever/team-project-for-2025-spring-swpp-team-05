using UnityEditor;

public class BuildScript
{
    static string[] scenes = { "Assets/Scenes/SampleScene.unity" };

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
