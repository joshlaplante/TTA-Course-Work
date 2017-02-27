function text_animation()
{
	element = document.getElementById("anim_text");
	var node = element.childNodes[0];
	var text = node.data;
	
	setInterval(function()
	{
		text = text[text.length-1] + text.substring(0, text.length-1);
		node.data = text;
	},
	200);
	
};