var OrderController = function (orderService) {

    var getOrders = function (success, error) {
        console.log("start calling order api");
        orderService.callOrderGetApi(success, error);
    }
    
    var success = function (orders) {
        console.log("retrieved orders");
        console.log(orders);
    };

    var error = function () {
        alert("Something failed! in getting orders");
    };

    

    var init = function () {
        console.log("start order controller");
        getOrders(success, error);
    };

    return {
        init: init
    }
}(OrderService)
