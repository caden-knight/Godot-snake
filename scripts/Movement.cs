using Godot;
using System;
using System.Diagnostics;

public partial class Movement : CharacterBody2D
{
	[Export]
	private float speed = 300f;

	public enum Direction
	{
		UP,
		DOWN,
		LEFT,
		RIGHT
	}
	public Direction currentDirection = Direction.RIGHT;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		ProcessMovement(currentDirection);

		MoveAndSlide();
	}

	void ProcessMovement(Direction direction)
	{
		switch (direction)
		{
			case Direction.RIGHT:
				Velocity = Vector2.Right * speed;
				break;
			case Direction.LEFT:
				Velocity = Vector2.Left * speed;
				break;
			case Direction.UP:
				Velocity = Vector2.Up * speed;
				break;
			case Direction.DOWN:
				Velocity = Vector2.Down * speed;
				break;
			default:
				Velocity = Vector2.Right * speed;
				break;

		}

		if (Input.IsActionJustPressed("right"))
		{
			currentDirection = Direction.RIGHT;
		}
		else if (Input.IsActionJustPressed("down"))
		{
			currentDirection = Direction.DOWN;
		}
	}
}
