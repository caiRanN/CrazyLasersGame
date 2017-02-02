using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void GameStart<T, U>(T sender, U argument);
public delegate void GameEnd<T, U>(T sender, U argument);
public delegate void PlayerKilled<T, U>(T sender, U argument);

public enum EventList {
	GameStart,
	GameEnd,
	PlayerKilled
}

public static class EventManager<T, U	> {
	public static event GameStart<T, U> GameStart;
	public static event GameEnd<T, U> GameEnd;
	public static event PlayerKilled<T, U> PlayerKilled;

	public static void LaunchEvent(EventList selectedEvent, T sender, U argument) {
		switch (selectedEvent) {
		case EventList.GameStart:
			if (GameStart != null) {
				GameStart(sender, argument);
			}
			break;

		case EventList.GameEnd:
			if (GameEnd != null) {
				GameEnd(sender, argument);
			}
			break;

		case EventList.PlayerKilled:
			if(PlayerKilled != null) {
				PlayerKilled(sender, argument);
			}
			break;
		}
	}
}
