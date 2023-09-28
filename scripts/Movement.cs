using Godot;
using System;
using System.Diagnostics;

public partial class Movement : CharacterBody2D
{
	[Export]
	private float speed = 300f;
	public Singleton singleton;
	private snake cloneScene;
	private Apple apple;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// @onready vars
		singleton = GetNode<Singleton>("/root/Singleton");
		apple = GetNode<Apple>("/root/Level1/Apple");

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		ProcessMovement(singleton.currentDirection);

		MoveAndSlide();
	}

	void ProcessMovement(Singleton.Direction direction)
	{
		switch (direction)
		{
			case Singleton.Direction.RIGHT:
				Velocity = Vector2.Right * speed;
				break;
			case Singleton.Direction.LEFT:
				Velocity = Vector2.Left * speed;
				break;
			case Singleton.Direction.UP:
				Velocity = Vector2.Up * speed;
				break;
			case Singleton.Direction.DOWN:
				Velocity = Vector2.Down * speed;
				break;
			default:
				Velocity = Vector2.Right * 0;
				break;

		}

		if (Input.IsActionJustPressed("right"))
		{
			singleton.currentDirection = Singleton.Direction.RIGHT;
		}
		else if (Input.IsActionJustPressed("down"))
		{
			singleton.currentDirection = Singleton.Direction.DOWN;
		}
		else if (Input.IsActionJustPressed("up"))
		{
			singleton.currentDirection = Singleton.Direction.UP;
		}
		else if (Input.IsActionJustPressed("left"))
		{
			singleton.currentDirection = Singleton.Direction.LEFT;
		}
	}
}
