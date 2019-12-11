$('a.dropdown-toggle, .dropdown-menu a').on('touchstart', function(e) { e.stopPropagation(); });
//fixed header
$("document").ready(function() {
$(window).scroll(function() {
	if ($(this).scrollTop() > 0) {
	$('header').addClass("hdr_fix");
	} else {
	$('header').removeClass("hdr_fix");
	}
});	
//equal-height
equalheight('.money-innr');
equalheight('.news-rights-inn');		
});

 
// ===== Scroll to Top ==== 
$(window).scroll(function() {
    if ($(this).scrollTop() >= 50) {        // If page is scrolled more than 50px
        $('#return-to-top').fadeIn(200);    // Fade in the arrow
    } else {
        $('#return-to-top').fadeOut(200);   // Else fade out the arrow
    }
});
$('#return-to-top').click(function() {      // When arrow is clicked
    $('body,html').animate({
        scrollTop : 0                       // Scroll to top of body
    }, 500);
});


(function($) {
      fakewaffle.responsiveTabs(['xs', 'sm']);
  })(jQuery);
//wow animation
!!window['addEventListener'] && new WOW().init();