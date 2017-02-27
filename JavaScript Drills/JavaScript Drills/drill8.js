function startgame()
{
	var number = Math.floor(Math.random() * 10) + 1;
	var guess = prompt("Guess a number from 1 to 10");
	if (number == guess)
	{
		alert("Nice, you win!");
	}
	else
	{
		alert("Nope, the number was " + number);
	}
}
