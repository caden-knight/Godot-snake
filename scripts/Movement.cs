using Godot;
using System;
using System.Diagnostics;
using System.Drawing;

public partial class Movement : CharacterBody2D
{
	[Export]
	private float speed = 300f;
	public Singleton singleton;
	private Apple apple;
	private PackedScene snakeCloneScene;
	public CharacterBody2D snakeClone;
	public int count = 0;



	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// @onready vars
		singleton = GetNode<Singleton>("/root/Singleton");
		apple = GetNode<Apple>("/root/Level1/Apple");
		snakeCloneScene = ResourceLoader.Load<PackedScene>("res://scenes/snakeTail.tscn");
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
			case Singleton.Direction.EAST:
				Velocity = Vector2.Right * speed;
				break;
			case Singleton.Direction.WEST:
				Velocity = Vector2.Left * speed;
				break;
			case Singleton.Direction.NORTH:
				Velocity = Vector2.Up * speed;
				break;
			case Singleton.Direction.SOUTH:
				Velocity = Vector2.Down * speed;
				break;
			default:
				Velocity = Vector2.Right * 0;
				break;

		}

		if (Input.IsActionJustPressed("right"))
		{
			singleton.currentDirection = Singleton.Direction.EAST;
		}
		else if (Input.IsActionJustPressed("down"))
		{
			singleton.currentDirection = Singleton.Direction.SOUTH;
		}
		else if (Input.IsActionJustPressed("up"))
		{
			singleton.currentDirection = Singleton.Direction.NORTH;
		}
		else if (Input.IsActionJustPressed("left"))
		{
			singleton.currentDirection = Singleton.Direction.WEST;
		}

		if (singleton.createSnakeTail)
		{
			snakeClone = snakeCloneScene.Instantiate<CharacterBody2D>();
			snakeClone.Position = Position + Vector2.Up * 10;
			GetTree().Root.AddChild(snakeClone);
			singleton.createSnakeTail = false;
		}
	}
}
