for (var year = 2014; year <= 2050; year++)  
    {  
    var datecheck = new Date(year, 0, 1);  
    if ( datecheck.getDay() == 0 )  
    {
        console.log("January 1st is a Sunday in " + year);  
    }  
    }