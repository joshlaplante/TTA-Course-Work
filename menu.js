$(document).ready(function(){
	$('.drop_items').hide();
	$('.drop_menu').hover(function() {
	$(this).children('.drop_items, .side_link').stop(true, false, true).slideToggle(300);
});
	
	
});
