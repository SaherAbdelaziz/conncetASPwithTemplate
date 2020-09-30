var PromoService = function () {

    var callPromoCheck = function (success, error, code) {//(success, errorSingle, code) {

        console.log("check promo");

        var promo = {
            Id:-1,
            Code: code
        };

        $.ajax({
            url: `/api/Promoes`,
            type: "POST",
            dataType: 'json',
            data: JSON.stringify(promo),
            contentType: "application/json; charset=utf-8",
            success: function (promo) {
                success(promo);
                //console.log("Found promo");
                //console.log(promo);
                //AJAXRequest(20);
            },
            error: function () {
                console.log("not found");
                $(".js-Coupon_warText").text("The coupon code entered is not valid. Perhaps you used the wrong coupon code?");
                $(".js-Coupon_warText").addClass("badge-danger");
            }
        });
    }
    var callAddPromoToCart = function (success, error, promoId) { //(success, errorSingle, code) {

        console.log("check promo");

        var cart = {
            Id: -1,
            PromoId: promoId,
            HasPromoCode: true
        };

        $.ajax({
            url: `/api/Carts/${-1}`,
            type: "PUT",
            dataType: 'json',
            data: JSON.stringify(cart),
            contentType: "application/json; charset=utf-8",
            success: function () {
                console.log("Cart Edited");
                success();
            },
            error: function () {
                console.log("Error in editing cart");
            }
        });
    }

    var callCheckUserUsage = function (success, error, promoId) { //(success, errorSingle, code) {


    }

    return {
        
        callPromoCheck: callPromoCheck,
        callCheckUserUsage: callCheckUserUsage
    }

}()