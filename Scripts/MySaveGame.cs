using System;

[Serializable]
public class MySaveGame : SaveGame
{
	public float MoneyFloat { get; set;}

	public float AppleFloat { get; set;}
	public float BreadFloat { get; set;}
	public float CharcoalFloat { get; set;}
	public float CheeseFloat { get; set;}
	public float ClothFloat { get; set;}
	public float CopperIngotFloat { get; set;}
	public float CopperOreFloat { get; set;}
	public float CornCobFloat { get; set;}
	public float DirtFloat { get; set;}
	public float EggFloat { get; set;}
	public float FeatherFloat { get; set;}
	public float FishFloat { get; set;}
	public float FleshFloat { get; set;}
	public float FlourFloat { get; set;}
	public float ForestFloat { get; set;}
	public float IronIngotFloat { get; set;}
	public float IronOreFloat { get; set;}
	public float MilkFloat { get; set;}
	public float PealFloat { get; set;}
	public float SaplingFloat { get; set;}
	public float StoneFloat { get; set;}
	public float StoneCoalFloat { get; set;}
	public float WaterFloat { get; set;}
	public float WheatFloat { get; set;}
	public float WoodLogFloat { get; set;}
	public float WoolFloat { get; set;}


	public int WheatFields { get; set;}
	public int Wells { get; set;}
	public int CharcoalClamps { get; set;}
	public int Windmills { get; set;}
	public int Bakerys { get; set;}
	public int WoodcutterHuts { get; set;}
	public int ForesterHuts { get; set;}
	public int TreeNurserys { get; set;}
	public int AppleTrees { get; set;}
	public int PealTrees { get; set;}
	public int CornFields { get; set;}
	public int ChickenFarms { get; set;}
	public int PigFarms { get; set;}
	public int SheepFarms { get; set;}
	public int CowFarms { get; set;}
	public int CheeseDairys { get; set;}
	public int WeavingMills { get; set;}
	public int FisherHuts { get; set;}
	public int StoneMines { get; set;}
	public int CoalMines { get; set;}
	public int CopperMines { get; set;}
	public int CopperFurnances { get; set;}
	public int IronMines { get; set;}
	public int IronFurnances { get; set;}

	//---unused for now---- Start
	//public float WheatFieldWheatPerSecound { get; set;}
	//public float WheatFieldWaterConsumePerSecound { get; set;}

	//public float WellWaterPerSecound { get; set;}

	//public float CharcoalClampCharcoalPerSecound { get; set;}
	//public float CharcoalClampWoodLogConsumePerSecound { get; set;}

	//public float WindmillFlourPerSecound { get; set;}
	//public float WindmillWheatConsumePerSecound;

	//public float BakeryBreadPerSecound { get; set;}
	//public float BakeryFlourConsumePerSecound { get; set;}
	//public float BakeryWaterConsumePerSecound { get; set;}
	//public float BakeryCharcoalConsumePerSecound { get; set;}

	//public float WoodcutterHutWoodLogPerSecound { get; set;}
	//public float WoodcutterHutForestConsumePerSecound { get; set;}

	//public float ForesterHutForestPerSecound { get; set;}
	//public float ForesterHutWaterConsumePerSecound { get; set;}
	//public float ForesterHutSaplingConsumePerSecound { get; set;}

	//public float TreeNurserySaplingsPerSecound { get; set;}
	//public float TreeNurseryWaterConsumePerSecound { get; set;}

	//public float AppleTreeApplePerSecound { get; set;}
	//public float AppleTreeWaterConsumePerSecound { get; set;}

	//public float PealTreePealPerSecound { get; set;}
	//public float PealTreeWaterConsumePerSecound { get; set;}

	//public float CornFieldCornCobPerSecound { get; set;}
	//public float CornFieldWaterConsumePerSecound { get; set;}

	//public float ChickenFarmFleshPerSecound { get; set;}
	//public float ChickenFarmEggPerSecound { get; set;}
	//public float ChickenFarmFeatherPerSecound { get; set;}
	//public float ChickenFarmWaterConsumePerSecound { get; set;}
	//public float ChickenFarmWheatConsumePerSecound { get; set;}
	//public float ChickenFarmCornCobConsumePerSecound { get; set;}

	//public float PigFarmFleshPerSecound { get; set;}
	//public float PigFarmWaterConsumePerSecound { get; set;}
	//public float PigFarmFruitConsumePerSecound { get; set;}

	//public float SheepFarmFleshPerSecound { get; set;}
	//public float SheepFarmWoolPerSecound { get; set;}
	//public float SheepFarmWaterConsumPerSecound { get; set;}
	//public float SheepFarmWheatPerSecound { get; set;}

	//public float CowFarmFleshPerSecound { get; set;}
	//public float CowFarmMilkPerSecound { get; set;}
	//public float CowFarmWaterConsumePerSecound { get; set;}
	//public float CowFarmWheatPerSecound { get; set;}

	//public float CheeseDairyCheesePerSecound { get; set;}
	//public float CheeseDairyMilkConsumePerSecound { get; set;}

	//public float WeavingMillClothPerSecound { get; set;}
	//public float WeavingMillWoolConsumePerSecound { get; set;}

	//public float FisherHutFishPerSecound { get; set;}
	//public float FisherHutIronConsumePerSecound { get; set;}
	//public float FisherHutWoodLogConsumePerSecound { get; set;}

	//public float StoneMineStonePerSecound { get; set;}
	//public float StoneMineCharcoalConsumePerSecound { get; set;}
	//public float StoneMineWoodLogConsumePerSecound { get; set;}

	//public float CoalMineStonePerSecound { get; set;}
	//public float CoalMineStoneCoalPerSecound { get; set;}
	//public float CoalMineCharcoalConsumePerSecound { get; set;}
	//public float CoalMineWoodLogConsumePerSecound { get; set;}

//	public float CopperMineStonePerSecound { get; set;}
//	public float CopperMineCopperOrePerSecound { get; set;}
//	public float CopperMineCharcoalConsumePerSecound { get; set;}
//	public float CopperMineWoodLogPerSecound { get; set;}

//	public float CopperFurnanceCopperIngotPerSecound { get; set;}
//	public float CopperFurnanceStoneCoalConsumePerSecound { get; set;}
//	public float CopperFurnanceCopperOreConsumePerSecound { get; set;}
//	public float CopperFurnanceWaterConsumePerSecound { get; set;}

//	public float IronMineStonePerSecound { get; set;}
//	public float IronMineIronOrePerSecound { get; set;}
//	public float IronMineCharcoalConsumePerSecound { get; set;}
//	public float IronMineWoodLogConsumePerSecound { get; set;}

//	public float IronFurnanceIronIngotPerSecound { get; set;}
//	public float IronFurnanceStoneCoalConsumePerSecound { get; set;}
//	public float IronFurnanceIronOreConsumePerSecound { get; set;}
//	public float IronFurnanceWaterConsumePerSecound { get; set;}
	//---unused for now---- End

	public int DirtBlockLevel { get; set;}
	public int StoneBlockLevel { get; set;}
	public int WoodLogBlockLevel { get; set;}
	public int TerrariaBlockLevel { get; set;}

	public int DirtBonus { get; set;}
	public int PebbleBonus { get; set;}
	public int StoneBonus { get; set;}
	public int WoodLogBonus { get; set;}
	public int TerrariaBonus { get; set;}

	public float posibilityDirtBonus { get; set;}
	public float posibilityPebble { get; set;}
	public float posibilityStoneBonus { get; set;}
	public float posibilityWoodLogBonus { get; set;}
	public float posibilityTerrariaBonus { get; set;}


	public float DirtBlockCoinCost { get; set;}
	public float StoneBlockCoinCost { get; set;}
	public float WoodLogBlockCoinCost { get; set;}
	public float TerrariaBlockCoinCost { get; set;}


	public float dirtPerClick { get; set;}
	public float stonePerClick { get; set;}
	public float woodLogPerClick { get; set;}
	public float terrariaDirtPerClick { get; set;}


	public int BlockClicks { get; set;}
}