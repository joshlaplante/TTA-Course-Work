function leapyear()
{
	year = window.prompt("Enter a year to check: ");
	if (year % 4 !== 0)
	{
		alert("Nope. Not a leap year.");
	}
	else if (year % 400 == 0)
	{
		alert("Yup! It's a leap year.'");
	}
	else if (year % 100 == 0)
	{
		alert("Nope. Not a leap year.");
	}
	else
	{
		alert("Yup! It's a leap year.'");
	}
}
