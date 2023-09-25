using Godot;
using System;

public partial class Singleton : Node
{
	public enum Direction
	{
		UP,
		DOWN,
		LEFT,
		RIGHT
	}
	public Direction currentDirection = Direction.RIGHT;
}
