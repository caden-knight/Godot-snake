using Godot;
using System;

public partial class SnakeTail : CharacterBody2D
{
	public CharacterBody2D snakeHead;
	public Vector2 snakeHeadSize;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// snakeHead = GetNode<CharacterBody2D>("/root/Level1/Snake");
		// snakeHeadSize = snakeHead.GetChild<Sprite2D>(0).Texture.GetSize();
		// Vector2 tailPosition = new Vector2(snakeHead.Position.X - snakeHeadSize.X, snakeHead.Position.Y);
		// Position = tailPosition;
		// GD.Print($"TP: {tailPosition} SHP: {snakeHead.Position}");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Velocity = snakeHead.Velocity;
		// Vector2 tailPosition = new Vector2(snakeHeadSize.X, snakeHeadSize.Y);
		// Position = snakeHead.Position;


	}
}
