using Godot;
using System;

public partial class AppleTimer : Timer
{
	// gets apple resource to spawn later
	public PackedScene appleRef = ResourceLoader.Load<PackedScene>("res://scenes/apple.tscn");
	public Singleton singleton;
	private float spawnRate = 3f; // in seconds



	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		singleton = GetNode<Singleton>("/root/Singleton");
		Start(spawnRate);
	}

	private void OnTimeout()
	{
		if (singleton.appleCollected)
		{
			Apple apple = appleRef.Instantiate<Apple>();
			AddChild(apple);
			float xPos = GD.RandRange(0, 1152);
			float yPos = GD.RandRange(0, 648);
			apple.Position = new Vector2(xPos, yPos);
			singleton.appleCollected = false;
		}
	}
}
