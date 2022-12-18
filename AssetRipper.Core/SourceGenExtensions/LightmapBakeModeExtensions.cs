﻿using AssetRipper.SourceGenerated.Enums;
using AssetRipper.SourceGenerated.Subclasses.LightmapBakeMode;

namespace AssetRipper.Core.SourceGenExtensions
{
	public static class LightmapBakeModeExtensions
	{
		public static LightmapBakeType GetLightmapBakeType(this ILightmapBakeMode light)
		{
			return (LightmapBakeType)light.LightmapBakeType;
		}
		public static SourceGenerated.NativeEnums.Global.MixedLightingMode GetMixedLightingMode(this ILightmapBakeMode light)
		{
			return (SourceGenerated.NativeEnums.Global.MixedLightingMode)light.MixedLightingMode;
		}
	}
}
