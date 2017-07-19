using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveMyDirt : MonoBehaviour {

//	public void LoadMoney() {
//		if (SaveGameSystem.DoesSaveGameExist("saveFile") == true) {
//			MySaveGame saveFile = SaveGameSystem.LoadGame ("saveFile") as MySaveGame;
			//ressources
//			PlayerStats.MoneyFloat = saveFile.MoneyFloat;
//		}
//	}

	public void LoadMoney() {
		Debug.Log ("It sould do something");
		if (SaveGameSystem.DoesSaveGameExist ("saveFile") == true) {
			Debug.Log ("There is a saveFile");
			MySaveGame saveFile = SaveGameSystem.LoadGame ("saveFile") as MySaveGame;
			Debug.Log ("saveFile Loaded");

			Debug.Log (PlayerStats.DirtFloat + " PlayerStats dirt float");
			Debug.Log (saveFile.DirtFloat + " saveFile dirt float");
//			PlayerStats.DirtFloat = saveFile.DirtFloat;
		}
	}
}