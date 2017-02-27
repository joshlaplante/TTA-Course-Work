function c_to_f()
{
	var celsius = prompt("Enter a temperature in Celsius to convert it to Farenheit.");
	farenheit = celsius * 9 / 5 + 32;
	alert(celsius +'\xB0C is ' + farenheit +'\xB0F.');
}

function f_to_c()
{
	var farenheit = prompt("Enter a temperature in Farenheit to convert it to Celsius.");
	celsius = (farenheit - 32) * 5 / 9;
	alert(farenheit +'\xB0F is ' + celsius +'\xB0C.');
}
