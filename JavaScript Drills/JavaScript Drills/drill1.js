var date = new Date();
var day = date.getDay();
var dayList = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];

var hour = date.getHours();
var minutes = date.getMinutes();
var seconds = date.getSeconds();
var period = null;

if (hour >= 12)
{
	period = "PM";
}
else
{
	period = "AM";
}

if (hour > 12)
{
	hour = hour - 12;
}

console.log("Today is: " + dayList[day] + ".");
console.log("Current time is: " + hour + ":" + minutes + ":" + seconds + " " + period);
