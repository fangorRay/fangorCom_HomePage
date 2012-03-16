$(document).ready(function () {
	
	$('#sidebar').css({left: '-270px'});
	
	$('#settings-btn').toggle(function(){
		$('#sidebar').animate({left: '0px'}, 200);
	}, function(){
		$('#sidebar').animate({left: '-270px'}, 200);
	});
	
	$('legend').click(function(){
		$(this).siblings().toggle();
	});
		
	function defaultState(parent, id){
		if($('#'+parent).is(':checked')){
			$('#'+id).removeAttr('disabled');
		}else{
			$('#'+id).attr('disabled', 'disabled');			
		}
	}
	
	function toggleDisable(id){
		if($('#'+id).is(':disabled')){
			$('#'+id).removeAttr('disabled');
		}else{
			$('#'+id).attr('disabled', 'disabled');
		}
	}
	
	function toggleDisableSlider(id){
		if($('#'+id).is(':disabled')){
			$('#'+id).removeAttr('disabled');
			$('#'+id + '_s').slider( "option", "disabled", false );
		}else{
			$('#'+id).attr('disabled', 'disabled');
			$('#'+id + '_s').slider( "option", "disabled", true );
		}
	}
	
	defaultState('indicator', 'indicator_autohide');
	defaultState('navigation', 'navigation_autohide');
	defaultState('tooltip', 'tooltip_effect');
	defaultState('slideshow', 'slideshow_timer');
	defaultState('slideshow', 'slideshow_hoverpause');
	defaultState('slideshow', 'slideshow_continuous');
	
	
	$('#indicator').click(function(){
		toggleDisable('indicator_autohide');
	});
	
	$('#navigation').click(function(){
		toggleDisable('navigation_autohide');
	});
	
	$('#tooltip').click(function(){
		toggleDisable('tooltip_effect');
	});
	
	$('#slideshow').click(function(){
		toggleDisableSlider('slideshow_speed');
		toggleDisable('slideshow_timer');
		toggleDisable('slideshow_continuous');
		toggleDisable('slideshow_hoverpause');
		toggleDisable('slideshow_infinite');
		toggleDisable('slideshow_autostart');
	});
	
	var transitions = {
		swap: ['top', 'right', 'bottom', 'left'],
		stretch: ['center', 'vertical', 'horizontal', 'alternate'],
		squeeze: ['center', 'vertical', 'horizontal', 'alternate'],
		shrink: ['topleft', 'topright', 'bottomleft', 'bottomright'],
		grow: ['topleft', 'topright', 'bottomleft', 'bottomright'],
		slide_in: ['top', 'right', 'bottom', 'left', 'alternate_vertical', 'alternate_horizontal'],
		slide_out: ['top', 'right', 'bottom', 'left', 'alternate_vertical', 'alternate_horizontal'],
		drop: ['topleft', 'topright', 'bottomleft', 'bottomright', 'top', 'right', 'bottom', 'left', 'alternate_vertical', 'alternate_horizontal'],
		appear: ['topleft', 'topright', 'bottomleft', 'bottomright', 'top', 'right', 'bottom', 'left', 'alternate_vertical', 'alternate_horizontal'],
		flash: [],
		fade: []
	};

	
	$('#animation_transition').change(function(){
		var transition = $(this).val();
		
		$('#animation_variation').empty();
		
		$.each(transitions[transition], function(){
			$('#animation_variation').append($('<option></option>').html(this.toString()));
		});
	});
	
	var directions = {
		horizontal: ['top', 'bottom', 'topleft', 'topright', 'bottomleft', 'bottomright'],
		vertical: ['left', 'right', 'topleft', 'topright', 'bottomleft', 'bottomright'],
		diagonal: ['topleft', 'topright', 'bottomleft', 'bottomright'],
		random: [],
		spiral: ['topleft', 'topright', 'bottomleft', 'bottomright'],
		horizontal_zigzag: ['topleft', 'topright', 'bottomleft', 'bottomright'],
		vertical_zigzag: ['topleft', 'topright', 'bottomleft', 'bottomright'],
		chess: [],
		explode: ['center', 'top', 'right', 'bottom', 'left'],
		implode: ['center', 'top', 'right', 'bottom', 'left'],
		example: []
	}
	$('#animation_type').change(function(){
		var type = $(this).val();
		
		$('#animation_direction').empty();
		
		$.each(directions[type], function(){
			$('#animation_direction').append($('<option></option>').html(this.toString()));
		});
	});


	$(".theme-selector").change(function(e) { 
		$("link#this").attr("href", "themes/"+$(this).val()+"/theme.css");
	});



});
