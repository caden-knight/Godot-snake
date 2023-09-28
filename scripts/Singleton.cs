using Godot;
using System;

public partial class Singleton : Node
{
	public bool appleCollected = false;
	public enum Direction
	{
		UP,
		DOWN,
		LEFT,
		RIGHT
	}
	public Direction currentDirection = Direction.RIGHT;
	public int score = 0;
	public Label scoreLabel;



	public override void _Ready()
	{
		scoreLabel = GetNode<Control>("/root/Level1/Score").GetChild<Label>(0);

	}
}
