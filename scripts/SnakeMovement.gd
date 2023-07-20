extends CharacterBody2D

@export var speed: float = 300.0

var currentDirection: Direction = Direction.RIGHT

enum Direction {
	UP,
	DOWN,
	LEFT,
	RIGHT
}

func _process(_delta):
	if Input.is_action_just_pressed("ui_down"):
		currentDirection = Direction.DOWN
	elif Input.is_action_just_pressed("ui_up"):
		currentDirection = Direction.UP
	elif Input.is_action_just_pressed("ui_left"):
		currentDirection = Direction.LEFT
	elif Input.is_action_just_pressed("ui_right"):
		currentDirection = Direction.RIGHT

	process_input(currentDirection)
	# FINALLY!!!! 
	# I, Ian Bradford, have discovered Caden's power source. It is only a matter of time
	# before he entirely transforms into me and listens to my every command. 
	
	# Reminds me of the time I was enlisted in the Nazi army...
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

# deletes player when they touch the screen bounds
func _on_bounds_body_entered(body):
	# remove the body only if body is the snake
	if body != self: return
	else:
		body.queue_free()
