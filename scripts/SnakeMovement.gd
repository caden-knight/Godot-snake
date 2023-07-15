extends CharacterBody2D

@export var speed: float = 300.0
enum Direction {
	UP,
	DOWN,
	LEFT,
	RIGHT
}

var currentDirection: Direction = Direction.RIGHT

func _process(delta):
	if Input.is_action_just_pressed("ui_down"):
		currentDirection = Direction.DOWN
	elif Input.is_action_just_pressed("ui_up"):
		currentDirection = Direction.UP
	elif Input.is_action_just_pressed("ui_left"):
		currentDirection = Direction.LEFT
	elif Input.is_action_just_pressed("ui_right"):
		currentDirection = Direction.RIGHT
		
	process_input(currentDirection)
	
	move_and_slide()
	
func process_input(direction: Direction):
	match direction:
		Direction.UP:
			velocity.x = 0
			velocity.y = -speed
		Direction.DOWN:
			velocity.x = 0
			velocity.y = speed
		Direction.LEFT:
			velocity.x = -speed
			velocity.y = 0
		Direction.RIGHT:
			velocity.x = speed
			velocity.y = 0
