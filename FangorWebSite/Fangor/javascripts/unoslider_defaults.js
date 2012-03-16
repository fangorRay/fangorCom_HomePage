$(document).ready(function(){
	$.UnoSlider.defaults = {
	  tooltip: true,
	  indicator: false,
	  navigation: { autohide: false },
	  slideshow: { hoverPause: true, continuous: true, timer: false, speed: 5, infinite: true, autostart: true },
	  responsive: true,
	  preset: ['chess', 'flash', 'spiral_reversed', 'spiral', 'sq_appear', 'sq_flyoff', 'sq_drop', 'sq_squeeze', 'sq_random', 'sq_diagonal_rev', 'sq_diagonal', 'sq_fade_random', 'sq_fade_diagonal_rev', 'sq_fade_diagonal', 'explode', 'implode', 'fountain', 'blind_bottom', 'blind_top', 'blind_right', 'blind_left', 'shot_right', 'shot_left', 'alternate_vertical', 'alternate_horizontal', 'zipper_right', 'zipper_left', 'bar_slide_random', 'bar_slide_bottomright', 'bar_slide_bottomright', 'bar_slide_topright', 'bar_slide_topleft', 'bar_fade_bottom', 'bar_fade_top', 'bar_fade_right', 'bar_fade_left', 'bar_fade_random', 'v_slide_top', 'h_slide_right', 'v_slide_bottom', 'h_slide_left', 'stretch', 'squeez', 'fade'],
	  order: 'random',
	  block: {
		vertical: 10,
		horizontal: 4
	  },
	  animation: {
		speed: 500,
		delay: 50,
		transition: 'grow',
		variation: 'topleft',
		pattern: 'diagonal',
		direction: 'topleft'
	  }
	}; 
	var slider = $("#frontpage_slider").unoslider();
  });