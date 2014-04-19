 $(window).load(function(){
      $('.flexslider').flexslider({
        controlNav: false,               //Boolean: Create navigation for paging control of each clide? Note: Leave true for manualControls usage
		directionNav: true,             //Boolean: Create navigation for previous/next navigation? (true/false)
		prevText: "",           //String: Set the text for the "previous" directionNav item
		nextText: "", 
        initDelay: 0,
		Delay:0, 
        animationSpeed:1500,
		before: function(){ $('.slideCapWrap').css('display','none'); $('.flex-direction-nav').css('display','none'); }, 
        after: function(){ $('.slideCapWrap').fadeIn(600); $('.flex-direction-nav').css('display','block');  },
		animation: "slide",
        start: function(slider){
          
        }
      });
    });

$(document).ready(function(){
    $('.dateSelect').datepicker();

    $( document ).tooltip({
      track: true
    });    
 });