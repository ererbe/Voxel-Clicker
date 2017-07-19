using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAndSaveAGame : MonoBehaviour {

	public void SaveTheGame (){
	MySaveGame saveFile = new MySaveGame ();
		//ressources
		saveFile.MoneyFloat = PlayerStats.MoneyFloat;
		saveFile.AppleFloat = PlayerStats.AppleFloat;
		saveFile.BreadFloat = PlayerStats.BreadFloat;
		saveFile.CharcoalFloat = PlayerStats.CharcoalFloat;
		saveFile.CheeseFloat = PlayerStats.CheeseFloat;
		saveFile.ClothFloat = PlayerStats.ClothFloat;
		saveFile.CopperIngotFloat = PlayerStats.CopperIngotFloat;
		saveFile.CopperOreFloat = PlayerStats.CopperOreFloat;
		saveFile.CornCobFloat = PlayerStats.CornCobFloat;
		saveFile.DirtFloat = PlayerStats.DirtFloat;
		saveFile.EggFloat = PlayerStats.EggFloat;
		saveFile.FeatherFloat = PlayerStats.FeatherFloat;
		saveFile.FishFloat = PlayerStats.FishFloat;
		saveFile.FleshFloat = PlayerStats.FleshFloat;
		saveFile.FlourFloat = PlayerStats.FlourFloat;
		saveFile.ForestFloat = PlayerStats.ForestFloat;
		saveFile.IronIngotFloat = PlayerStats.IronIngotFloat;
		saveFile.IronOreFloat = PlayerStats.IronOreFloat;
		saveFile.MilkFloat = PlayerStats.MilkFloat;
		saveFile.PealFloat = PlayerStats.PealFloat;
		saveFile.SaplingFloat = PlayerStats.SaplingFloat;
		saveFile.StoneFloat = PlayerStats.StoneFloat;
		saveFile.StoneCoalFloat = PlayerStats.StoneCoalFloat;
		saveFile.WaterFloat = PlayerStats.WaterFloat;
		saveFile.WheatFloat = PlayerStats.WheatFloat;
		saveFile.WoodLogFloat = PlayerStats.WoodLogFloat;
		saveFile.WoolFloat = PlayerStats.WoolFloat;
		//structures
		saveFile.WheatFields = PlayerStats.WheatFields;
		saveFile.Wells = PlayerStats.Wells;
		saveFile.CharcoalClamps = PlayerStats.CharcoalClamps;
		saveFile.Windmills = PlayerStats.Windmills;
		saveFile.Bakerys = PlayerStats.Bakerys;
		saveFile.WoodcutterHuts = PlayerStats.WoodcutterHuts;
		saveFile.ForesterHuts = PlayerStats.ForesterHuts;
		saveFile.TreeNurserys = PlayerStats.TreeNurserys;
		saveFile.AppleTrees = PlayerStats.AppleTrees;
		saveFile.PealTrees = PlayerStats.PealTrees;
		saveFile.CornFields = PlayerStats.CornFields;
		saveFile.ChickenFarms = PlayerStats.ChickenFarms;
		saveFile.PigFarms = PlayerStats.PigFarms;
		saveFile.SheepFarms = PlayerStats.SheepFarms;
		saveFile.CowFarms = PlayerStats.CowFarms;
		saveFile.CheeseDairys = PlayerStats.CheeseDairys;
		saveFile.WeavingMills = PlayerStats.WeavingMills;
		saveFile.FisherHuts = PlayerStats.FisherHuts;
		saveFile.StoneMines = PlayerStats.StoneMines;
		saveFile.CoalMines = PlayerStats.CoalMines;
		saveFile.CopperMines = PlayerStats.CopperMines;
		saveFile.CopperFurnances = PlayerStats.CopperFurnances;
		saveFile.IronMines = PlayerStats.IronMines;
		saveFile.IronFurnances = PlayerStats.IronFurnances;
		//block Stats
		saveFile.DirtBlockLevel = DirtBlock.DirtBlockLevel;
		saveFile.DirtBonus = DirtBlock.DirtBonus;
		saveFile.PebbleBonus = DirtBlock.PebbleBonus;
		saveFile.posibilityDirtBonus = DirtBlock.posibilityDirtBonus;
		saveFile.posibilityPebble = DirtBlock.posibilityPebble;
		saveFile.StoneBlockLevel = StoneBlock.StoneBlockLevel;
		saveFile.StoneBonus = StoneBlock.StoneBonus;
		saveFile.posibilityStoneBonus = StoneBlock.posibilityStoneBonus;
		saveFile.WoodLogBlockLevel = WoodLogBlock.WoodLogBlockLevel;
		saveFile.WoodLogBonus = WoodLogBlock.WoodLogBonus;
		saveFile.posibilityWoodLogBonus = WoodLogBlock.posibilityWoodLogBonus;
		saveFile.TerrariaBlockLevel = TerrariaBlock.TerrariaBlockLevel;
		saveFile.TerrariaBonus = TerrariaBlock.TerrariaBonus;
		saveFile.posibilityTerrariaBonus = TerrariaBlock.posibilityTerrariaBonus;
		//block Costs
		saveFile.DirtBlockCoinCost = CubeShopManager.DirtBlockCoinCost;
		saveFile.StoneBlockCoinCost = CubeShopManager.StoneBlockCoinCost;
		saveFile.WoodLogBlockCoinCost = CubeShopManager.WoodLogBlockCoinCost;
		saveFile.TerrariaBlockCoinCost = CubeShopManager.TerrariaBlockCoinCost;
		//clickStats
		saveFile.dirtPerClick = PlayerStats.dirtPerClick;
		saveFile.stonePerClick = PlayerStats.stonePerClick;
		saveFile.woodLogPerClick = PlayerStats.woodLogPerClick;
		saveFile.terrariaDirtPerClick = PlayerStats.terrariaDirtPerClick;
		//PlayerStats
		saveFile.BlockClicks = PlayerStats.BlockClicks;
		SaveGameSystem.SaveGame(saveFile, "saveFile");
		Debug.Log ("saved...");
	}

	public void LoadTheGame() {
		if (SaveGameSystem.DoesSaveGameExist("saveFile") == true) {
			MySaveGame saveFile = SaveGameSystem.LoadGame ("saveFile") as MySaveGame;
			//ressources
			PlayerStats.MoneyFloat = saveFile.MoneyFloat;
			PlayerStats.AppleFloat = saveFile.AppleFloat;
			PlayerStats.BreadFloat = saveFile.BreadFloat;
			PlayerStats.CharcoalFloat = saveFile.CharcoalFloat;
			PlayerStats.CheeseFloat = saveFile.CheeseFloat;
			PlayerStats.ClothFloat = saveFile.ClothFloat;
			PlayerStats.CopperIngotFloat = saveFile.CopperIngotFloat;
			PlayerStats.CopperOreFloat = saveFile.CopperOreFloat;
			PlayerStats.CornCobFloat = saveFile.CornCobFloat;
			PlayerStats.DirtFloat = saveFile.DirtFloat;
			PlayerStats.EggFloat = saveFile.EggFloat;
			PlayerStats.FeatherFloat = saveFile.FeatherFloat;
			PlayerStats.FishFloat = saveFile.FishFloat;
			PlayerStats.FleshFloat = saveFile.FleshFloat;
			PlayerStats.FlourFloat = saveFile.FlourFloat;
			PlayerStats.ForestFloat = saveFile.ForestFloat;
			PlayerStats.IronIngotFloat = saveFile.IronIngotFloat;
			PlayerStats.IronOreFloat = saveFile.IronOreFloat;
			PlayerStats.MilkFloat = saveFile.MilkFloat;
			PlayerStats.PealFloat = saveFile.PealFloat;
			PlayerStats.SaplingFloat = saveFile.SaplingFloat;
			PlayerStats.StoneFloat = saveFile.StoneFloat;
			PlayerStats.StoneCoalFloat = saveFile.StoneCoalFloat;
			PlayerStats.WaterFloat = saveFile.WaterFloat;
			PlayerStats.WheatFloat = saveFile.WheatFloat;
			PlayerStats.WoodLogFloat = saveFile.WoodLogFloat;
			PlayerStats.WoolFloat = saveFile.WoolFloat;
			//structures
			PlayerStats.WheatFields = saveFile.WheatFields;
			PlayerStats.Wells = saveFile.Wells;
			PlayerStats.CharcoalClamps = saveFile.CharcoalClamps;
			PlayerStats.Windmills = saveFile.Windmills;
			PlayerStats.Bakerys = saveFile.Bakerys;
			PlayerStats.WoodcutterHuts = saveFile.WoodcutterHuts;
			PlayerStats.ForesterHuts = saveFile.ForesterHuts;
			PlayerStats.TreeNurserys = saveFile.TreeNurserys;
			PlayerStats.AppleTrees = saveFile.AppleTrees;
			PlayerStats.PealTrees = saveFile.PealTrees;
			PlayerStats.CornFields = saveFile.CornFields;
			PlayerStats.ChickenFarms = saveFile.ChickenFarms;
			PlayerStats.PigFarms = saveFile.PigFarms;
			PlayerStats.SheepFarms = saveFile.SheepFarms;
			PlayerStats.CowFarms = saveFile.CowFarms;
			PlayerStats.CheeseDairys = saveFile.CheeseDairys;
			PlayerStats.WeavingMills = saveFile.WeavingMills;
			PlayerStats.FisherHuts = saveFile.FisherHuts;
			PlayerStats.StoneMines = saveFile.StoneMines;
			PlayerStats.CoalMines = saveFile.CoalMines;
			PlayerStats.CopperMines = saveFile.CopperMines;
			PlayerStats.CopperFurnances = saveFile.CopperFurnances;
			PlayerStats.IronMines = saveFile.IronMines;
			PlayerStats.IronFurnances = saveFile.IronFurnances;
			//block Stats
			DirtBlock.DirtBlockLevel = saveFile.DirtBlockLevel;
			DirtBlock.DirtBonus = saveFile.DirtBonus;
			DirtBlock.PebbleBonus = saveFile.PebbleBonus;
			DirtBlock.posibilityDirtBonus = saveFile.posibilityDirtBonus;
			DirtBlock.posibilityPebble = saveFile.posibilityPebble;
			StoneBlock.StoneBlockLevel = saveFile.StoneBlockLevel;
			StoneBlock.StoneBonus = saveFile.StoneBonus;
			StoneBlock.posibilityStoneBonus = saveFile.posibilityStoneBonus;
			WoodLogBlock.WoodLogBlockLevel = saveFile.WoodLogBlockLevel;
			WoodLogBlock.WoodLogBonus = saveFile.WoodLogBonus;
			WoodLogBlock.posibilityWoodLogBonus = saveFile.posibilityWoodLogBonus;
			TerrariaBlock.TerrariaBlockLevel = saveFile.TerrariaBlockLevel;
			TerrariaBlock.TerrariaBonus = saveFile.TerrariaBonus;
			TerrariaBlock.posibilityTerrariaBonus = saveFile.posibilityTerrariaBonus;
			//block Costs
			CubeShopManager.DirtBlockCoinCost = saveFile.DirtBlockCoinCost;
			CubeShopManager.StoneBlockCoinCost = saveFile.StoneBlockCoinCost;
			CubeShopManager.WoodLogBlockCoinCost = saveFile.WoodLogBlockCoinCost;
			CubeShopManager.TerrariaBlockCoinCost = saveFile.TerrariaBlockCoinCost;
			//clickStats
			PlayerStats.dirtPerClick = saveFile.dirtPerClick;
			PlayerStats.stonePerClick = saveFile.stonePerClick;
			PlayerStats.woodLogPerClick = saveFile.woodLogPerClick;
			PlayerStats.terrariaDirtPerClick = saveFile.terrariaDirtPerClick;
			//PlayerStats
			PlayerStats.BlockClicks = saveFile.BlockClicks;
		}
	}
}