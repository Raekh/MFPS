﻿using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public MatchSettings matchSettings;

	void Awake(){
		if(instance != null){
			Debug.LogError("More than one GM in scene");
		} else {
			instance = this;
		}
	}

	#region Player tracking
	private const string PLAYER_ID_PREFIX = "Player ";
	private static Dictionary<string, Player> players = new Dictionary<string, Player>();

	public static void RegisterPlayer(string _netID, Player _player){
		string _playerId = PLAYER_ID_PREFIX + _netID;
		players.Add(_playerId, _player);
		_player.transform.name = _playerId;
	}

	public static void UnRegisterPlayer(string _playerId){
		players.Remove(_playerId);
	}

	public static Player GetPlayer(string _playerId){
		return players[_playerId];
	}

	void OnGUI() {
		GUILayout.BeginArea(new Rect(200,200,200,500));	
		GUILayout.BeginVertical();

		foreach (string _playerId in players.Keys)
		{
			GUILayout.Label(_playerId + " - " + players[_playerId].transform.name);
		}

		GUILayout.EndVertical();
		GUILayout.EndArea();
	}
	#endregion



}