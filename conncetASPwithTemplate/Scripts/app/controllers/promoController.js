var PromoController = function (promoService) {

    var init = function (code) {
        console.log("start Promo controller" , code);
        promoService.callPromoCheck(successPromoCheck, errorPromoCheck, code);
    };

    var successPromoCheck = function (promo) {
        console.log(promo.id);
        console.log(promo.discountId);
        //here we found the promo is ok so we should add it to the cart
        promoService.callAddPromoToCart(successAddPromoToCart, errorAddPromoToCart, promo.id, promo.discountId);

    }

    var errorPromoCheck = function () {

    }

    var successAddPromoToCart = function () {

    }

    var errorAddPromoToCart = function () {

    }
    return {
        init: init
    }
}(PromoService)