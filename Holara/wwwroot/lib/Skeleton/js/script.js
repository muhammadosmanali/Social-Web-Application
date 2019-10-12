$(window).resize(function() {
    if($(window).width() <= 560) {
      $ads1 = $(".ads1").hide();
      $(".col1").removeClass("nine columns");
      $(".dropdown").removeClass("u-full-width");
      $(".dropdown").addClass("select-for");
    }
    else if($(window).width() <= 577) {
      $(".dropdown-div").addClass("select-for1");
    }
    else{
      $ads1 = $(".ads1").show();
      $(".col1").addClass("nine columns");
      $(".dropdown").addClass("u-full-width");
      $(".dropdown").removeClass("select-for");
    }
});

