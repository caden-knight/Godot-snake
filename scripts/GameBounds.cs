using Godot;
using System;

public partial class GameBounds : Area2D
{
	public Singleton singleton;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		singleton = GetNode<Singleton>("/root/Singleton");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void OnBodyEntered(Node2D body)
	{
		body.Position = new Vector2(200, 50);
		singleton.currentDirection = Singleton.Direction.DOWN;
		// CharacterBody2D player = GetNode<CharacterBody2D>("../Snake");
		// player.Velocity = new Vector2(0, 0);
		// GD.Print("loser");
	}
}
