extends Node2D


# Declare member variables here. Examples:
# var a = 2
# var b = "text"
var selected = false
var previousText = "derp"


# Called when the node enters the scene tree for the first time.
func _ready():
	get_node("Button").connect("pressed", self, "_on_Button_pressed")
	previousText = get_node("Label").text

func _on_Button_pressed():
	selected = !selected
	if (selected):
		get_node("Label").text = "selected!"
	else:
		get_node("Label").text = previousText
	
	get_node("GreenSprite").visible = !selected
	get_node("YellowSprite").visible = selected
	
		
	
	
# Called every frame. 'delta' is the elapsed time since the previous frame.
#func _process(delta):
#	pass
