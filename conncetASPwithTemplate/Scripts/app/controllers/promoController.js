var PromoController = function (promoService) {

    var init = function (code) {
        console.log("start Promo controller" , code);
        promoService.callPromoCheck(successPromoCheck, errorPromoCheck, code);
    };

    var successPromoCheck = function (promo) {
        console.log(promo.id);
        console.log(promo.discountId);

        //now we found that the promo code is exist so we check if the user already used it before and how many times 
        promoService.callCheckUserUsage(successCheckUserUsage, errorCheckUserUsage, promo.id, promo.discountId);

        //here we found the promo is ok so we should add it to the cart
        promoService.callAddPromoToCart(successAddPromoToCart, errorAddPromoToCart, promo.id, promo.discountId);

    }

    var errorPromoCheck = function () {

    }

    var successAddPromoToCart = function () {
        location.reload();
    }

    var errorAddPromoToCart = function () {

    }

    var successCheckUserUsage = function () {
        location.reload();
    }

    var errorCheckUserUsage = function () {

    }
    return {
        init: init
    }
}(PromoService)