using System;
using System.Linq;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;

namespace AssetBundleGraph.Modifiers {
	
	/*
	 * Code template for Animation modifier.
	 * You can copy and create your CustomModifier.
	 */ 
	[Serializable] 
	[CustomModifier("Default Modifier(AvatarMask)", typeof(AvatarMask))]
	public class AvatarMaskModifier : IModifier {
		
		public AvatarMaskModifier () {}

		public bool IsModified (object asset) {
			//var anim = asset as AvatarMask;

			// Do your work here

			var changed = false;
			return changed; 
		}

		public void Modify (object asset) {
			//var anim = asset as AvatarMask;

			// Do your work here
		}

		public void OnInspectorGUI (Action onValueChanged) {
			GUILayout.Label("Implement your modifier for this type.");
		}

		public string Serialize() {
			return JsonUtility.ToJson(this);
		}
	}
}