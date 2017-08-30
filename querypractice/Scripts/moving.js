
$(document).ready(function(){
    $("p").click(function(){
        $(this).hide();
    });

    $("#hide").click(function(){
        $("p").hide();
    });

    $("#display").click(function(){
        $("p").show();
    });

    $("#fade").click(function(){
        $("canvas").hide(1000);
    });

    $("button").click(function(){
        $("#fadez").fadeIn();
        $("#fadie").fadeIn(2000);
        $("#fad").fadeIn(4000);
    });

    $("#show").click(function(){
        $("canvas").fadeIn();
    });

});
    function feel(){
        var store =
        document.getElementById
           ('real').value;
        document.getElementById
            ('work').innerHTML = "hello joe" +
                store;
    }



