function daystilxmas()
{
	today = new Date();
	xmas = new Date(today.getFullYear(), 11, 25);
	if (today.getMonth() == 11 && today.getDate() > 25)
	{
		xmas.setFullYear(xmas.getFullYear() + 1);
	}
	
	var day_in_ms = 1000*60*60*24;
	var time_diff = (xmas.getTime() - today.getTime()) / day_in_ms;
	var days_left = Math.ceil(time_diff);
	alert("There are " + days_left + " days left until Christmas.");
};
