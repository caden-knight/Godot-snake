using Godot;
using System;

public partial class AppleTimer : Timer
{
	// gets apple resource to spawn later
	public PackedScene appleRef = ResourceLoader.Load<PackedScene>("res://scenes/apple.tscn");
	public Singleton singleton;
	private float spawnRate = GD.RandRange(1, 5); // in seconds

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
			// spawn new apple and position it
			Apple apple = appleRef.Instantiate<Apple>();
			AddChild(apple);
			float xPos = GD.RandRange(0, 1050);
			float yPos = GD.RandRange(0, 600);
			apple.Position = new Vector2(xPos, yPos);

			// switch back to false so too many apples don't spawn at once
			singleton.appleCollected = false;
		}

		spawnRate = GD.RandRange(1, 5);
	}
}
