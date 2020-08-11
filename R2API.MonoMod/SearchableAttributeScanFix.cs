﻿// Fix for the RoR2 Class SearchableAttribute scanning modding core assemblies creating in-game stuttering.

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedMember.Global
// ReSharper disable NotAccessedField.Local

#pragma warning disable IDE0052 // Remove unread private members
#pragma warning disable IDE1006 // Naming Styles
#pragma warning disable IDE0044 // Add readonly modifier

using System;
using System.Collections.Generic;
using MonoMod;

namespace RoR2 {
    internal class patch_SearchableAttribute : Attribute {
        [MonoModConstructor]
        static patch_SearchableAttribute() {
            instancesListsByType = new Dictionary<Type, List<SearchableAttribute>>();
            assemblyBlacklist = new HashSet<string> {
                "MMHOOK_Assembly-CSharp",
                "BepInEx",
                "BepInEx.Preloader",
                "BepInEx.Harmony",
                "BepInEx.MonoMod.Loader",
                "0Harmony",
                "Mono.Cecil",
                "Mono.Cecil.Pdb",
                "Mono.Cecil.Mdb",
                "MonoMod",
                "MonoMod.RuntimeDetour",
                "MonoMod.RuntimeDetour.HarmonySharedState",
                "MonoMod.Utils",
                "MonoMod.Utils.GetManagedSizeHelper",
                "MonoMod.Utils.Cil.ILGeneratorProxy",
                "R2API",
                "Assembly-CSharp.R2API.mm.MonoModRules [MMILRT, ID:0]",
                "mscorlib",
                "UnityEngine",
                "UnityEngine.AIModule",
                "UnityEngine.ARModule",
                "UnityEngine.AccessibilityModule",
                "UnityEngine.AnimationModule",
                "UnityEngine.AssetBundleModule",
                "UnityEngine.AudioModule",
                "UnityEngine.BaselibModule",
                "UnityEngine.ClothModule",
                "UnityEngine.ClusterInputModule",
                "UnityEngine.ClusterRendererModule",
                "UnityEngine.CoreModule",
                "UnityEngine.CrashReportingModule",
                "UnityEngine.DirectorModule",
                "UnityEngine.FileSystemHttpModule",
                "UnityEngine.GameCenterModule",
                "UnityEngine.GridModule",
                "UnityEngine.HotReloadModule",
                "UnityEngine.IMGUIModule",
                "UnityEngine.ImageConversionModule",
                "UnityEngine.InputModule",
                "UnityEngine.JSONSerializeModule",
                "UnityEngine.LocalizationModule",
                "UnityEngine.ParticleSystemModule",
                "UnityEngine.PerformanceReportingModule",
                "UnityEngine.PhysicsModule",
                "UnityEngine.Physics2DModule",
                "UnityEngine.ProfilerModule",
                "UnityEngine.ScreenCaptureModule",
                "UnityEngine.SharedInternalsModule",
                "UnityEngine.SpatialTrackingModule",
                "UnityEngine.SpriteMaskModule",
                "UnityEngine.SpriteShapeModule",
                "UnityEngine.StreamingModule",
                "UnityEngine.StyleSheetsModule",
                "UnityEngine.SubstanceModule",
                "UnityEngine.TLSModule",
                "UnityEngine.TerrainModule",
                "UnityEngine.TerrainPhysicsModule",
                "UnityEngine.TextCoreModule",
                "UnityEngine.TextRenderingModule",
                "UnityEngine.TilemapModule",
                "UnityEngine.TimelineModule",
                "UnityEngine.UIModule",
                "UnityEngine.UIElementsModule",
                "UnityEngine.UNETModule",
                "UnityEngine.UmbraModule",
                "UnityEngine.UnityAnalyticsModule",
                "UnityEngine.UnityConnectModule",
                "UnityEngine.UnityTestProtocolModule",
                "UnityEngine.UnityWebRequestModule",
                "UnityEngine.UnityWebRequestAssetBundleModule",
                "UnityEngine.UnityWebRequestAudioModule",
                "UnityEngine.UnityWebRequestTextureModule",
                "UnityEngine.UnityWebRequestWWWModule",
                "UnityEngine.VFXModule",
                "UnityEngine.VRModule",
                "UnityEngine.VehiclesModule",
                "UnityEngine.VideoModule",
                "UnityEngine.WindModule",
                "UnityEngine.XRModule",
                "UnityEditor",
                "Unity.Locator",
                "System.Core",
                "System",
                "Mono.Security",
                "System.Configuration",
                "System.Xml",
                "Unity.DataContract",
                "Unity.PackageManager",
                "UnityEngine.UI",
                "UnityEditor.UI",
                "UnityEditor.TestRunner",
                "UnityEngine.TestRunner",
                "nunit.framework",
                "UnityEngine.Timeline",
                "UnityEditor.Timeline",
                "UnityEngine.Networking",
                "UnityEditor.Networking",
                "UnityEditor.GoogleAudioSpatializer",
                "UnityEngine.GoogleAudioSpatializer",
                "UnityEditor.SpatialTracking",
                "UnityEngine.SpatialTracking",
                "UnityEditor.VR",
                "UnityEditor.Graphs",
                "UnityEditor.WindowsStandalone.Extensions",
                "SyntaxTree.VisualStudio.Unity.Bridge",
                "Rewired_ControlMapper_CSharp_Editor",
                "Rewired_CSharp_Editor",
                "Unity.ProBuilder.AddOns.Editor",
                "Wwise-Editor",
                "Unity.RenderPipelines.Core.Editor",
                "Unity.RenderPipelines.Core.Runtime",
                "Unity.TextMeshPro.Editor",
                "Unity.PackageManagerUI.Editor",
                "Rewired_NintendoSwitch_CSharp",
                "Unity.Postprocessing.Editor",
                "Rewired_CSharp",
                "Unity.Postprocessing.Runtime",
                "Rewired_NintendoSwitch_CSharp_Editor",
                "Wwise",
                "Unity.RenderPipelines.Core.ShaderLibrary",
                "Unity.TextMeshPro",
                "Rewired_UnityUI_CSharp_Editor",
                "Facepunch.Steamworks",
                "Rewired_Editor",
                "Rewired_Core",
                "Rewired_Windows_Lib",
                "Rewired_NintendoSwitch_Editor",
                "Rewired_NintendoSwitch_EditorRuntime",
                "Zio",
                "AssetIdRemapUtility",
                "ProBuilderCore",
                "ProBuilderMeshOps",
                "KdTreeLib",
                "pb_Stl",
                "Poly2Tri",
                "ProBuilderEditor",
                "netstandard",
                "System.Xml.Linq",
                "Unity.Cecil",
                "Unity.SerializationLogic",
                "Unity.Legacy.NRefactory",
                "ExCSS.Unity",
                "Unity.IvyParser",
                "UnityEditor.iOS.Extensions.Xcode",
                "SyntaxTree.VisualStudio.Unity.Messaging",
                "Microsoft.GeneratedCode",
                "Anonymously",
                "Hosted",
                "DynamicMethods",
                "Assembly"
            };
            try {
                typeof(SearchableAttribute).GetMethod("Scan", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static).Invoke(null,null);
            }
            catch (Exception ex) {
                System.Console.WriteLine(ex.Message);
            }
        }

        private static readonly Dictionary<Type, List<SearchableAttribute>> instancesListsByType;


        private static HashSet<string> assemblyBlacklist;

    }
}
#pragma warning restore IDE0052 // Remove unread private members
#pragma warning restore IDE1006 // Naming Styles
#pragma warning restore IDE0044 // Add readonly modifier
