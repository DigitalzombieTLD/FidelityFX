using System;
using MelonLoader;
using Harmony;
using UnityEngine;
using System.Reflection;
using System.Xml.XPath;
using System.Globalization;
using UnhollowerRuntimeLib;
using AMD_FIDELITY_FX;

namespace FidelityFX
{
    public class FidelityFX_Main : MelonMod
    {
		public static AssetBundle FidelityFXBundle;
		public static ComputeShader EdgeAdaptiveScaleUpsampling;
		public static ComputeShader RobustContrastAdaptiveSharpen;

		public static bool followPlayer = false;

		public override void OnApplicationStart()
        {
			ClassInjector.RegisterTypeInIl2Cpp<AMD_FIDELITY_FX_FSR>();

			FidelityFXBundle = AssetBundle.LoadFromFile("Mods\\ffx.unity3d");

			if (FidelityFXBundle == null)
			{
				MelonLogger.Msg("Failed to load AssetBundle (ffx.unity3d)!");
				return;
			}

			EdgeAdaptiveScaleUpsampling = FidelityFXBundle.LoadAsset<ComputeShader>("EdgeAdaptiveScaleUpsampling");
			RobustContrastAdaptiveSharpen = FidelityFXBundle.LoadAsset<ComputeShader>("RobustContrastAdaptiveSharpen");

			MelonLogger.Msg("ffx.unity3d succesfully loaded");
			
		}

		public override void OnSceneWasLoaded(int buildIndex, string sceneName)
		{
			
		}

		public override void OnUpdate()
		{
			DumbFuckery_Main.DoShizzAllTheTime();
		}
	}
}
