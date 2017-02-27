var side1 = 5;
var side2 = 6;
var side3 = 7;
var perimeter = side1 + side2 + side3;
var semiperimeter = perimeter / 2;

var area = Math.sqrt(semiperimeter * (semiperimeter-side1) * (semiperimeter-side2) * (semiperimeter-side3));

console.log(area);

