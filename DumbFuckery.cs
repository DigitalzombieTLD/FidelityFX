using System;
using MelonLoader;
using Harmony;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using System.Xml.XPath;
using System.Globalization;
using UnhollowerRuntimeLib;
using AMD_FIDELITY_FX;

namespace FidelityFX
{
	public class DumbFuckery_Main : MonoBehaviour
	{
		public static void DoSomeShizz()
		{			
			if(FidelityFX_Main.FidelityFXBundle != null)
			{
		
			}
		}

		public static void DoShizzAllTheTime()
		{			
			if (InputManager.GetKeyDown(InputManager.m_CurrentContext, KeyCode.Keypad0))
			{
				MelonLogger.Msg("*Doing shizz!!!*");
				GameManager.m_MainCamera.gameObject.AddComponent<AMD_FIDELITY_FX_FSR>();
				
				DoSomeShizz();
			}
		}
	}
}
