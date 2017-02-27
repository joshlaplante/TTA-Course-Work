$(document).ready(function(){
	
	/* first two animations make boxes disappear when moused over, reappear when moused off*/
	
	$('.box').mouseenter(function(){
		$(this).animate({opacity: '0'},300);
	
	});
	
	$('.box').mouseleave(function(){
		$(this).animate({opacity: '1'},300);
	
	});
	
	/* next two animations make the win_box disappear and the win_star appear when moused over, 
	 * and the win_box reappear and the win_star disappear when mosued off*/
	
	$('.win_box, .win_star').mouseenter(function(){
		$(this).animate({opacity: '0'},300);
		$('.win_star').animate({opacity: '1'},1);
		
	});
	
	$('.win_box, .win_star').mouseleave(function(){
		$(this).animate({opacity: '1'},300);
		$('.win_star').animate({opacity: '0'},500);
		
	});
	
	/* final animation makes the win_text appear when the win_box or win_star are clicked*/
	
	$('.win_box, .win_star').click(function(){
		$('.win_text').animate({opacity: '1'},100);
		
	
	});
	
});
