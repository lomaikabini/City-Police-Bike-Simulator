﻿using UnityEngine;
using System.Collections;

public class GoTo : MonoBehaviour {
	

	public static void LoadMenu()
	{
		Application.LoadLevel ("main_menu");
	}

	public static void LoadEnvironmentChoose()
	{
		Application.LoadLevel ("environment_choose");
	}

	public static void LoadGameTownOne()
	{
		Application.LoadLevel ("main_game_town_1");
	}

	public static void LoadGameTownTwo()
	{
		Application.LoadLevel ("main_game_town_2");
	}

	public static void LoadGameDirty()
	{
		Application.LoadLevel ("main_game_town_dirt");
	}

	public static void LoadGameSnow()
	{
		Application.LoadLevel ("main_game_town_snow");
	}

	public static void LoadGameTrack()
	{
		Application.LoadLevel ("main_game_town_track");
	}

	public static void LoadShop()
	{
		Application.LoadLevel ("main_shop");
	}

}