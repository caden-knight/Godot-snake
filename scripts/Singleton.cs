using Godot;
using System;

public partial class Singleton : Node
{
	public bool appleCollected = false;
	public enum Direction
	{
		NORTH,
		SOUTH,
		EAST,
		WEST
	}
	public Direction currentDirection = Direction.EAST;
	public int score = 0;
	public Label scoreLabel;
	public bool createSnakeTail = false;



	public override void _Ready()
	{
		scoreLabel = GetNode<Control>("/root/Level1/Score").GetChild<Label>(0);

	}
}
