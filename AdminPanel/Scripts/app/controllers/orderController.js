﻿var OrderController = function (orderService) {
    var orders , count=0;
    var getOrders = function (success, error) {
        console.log("start calling order api");
        orderService.callOrderGetApi(success, error);
    }
    
    var success = function (orders) {
        //console.log("retrieved orders");
        //console.log(orders);
       
        OrderController.orders = orders;
        //console.log(OrderController.orders);
        OrderController.count = OrderController.orders.length;
    };

    var successAccept = function (e) {
        console.log(" order accepted");
        var td = $(e.target);
        td.parents("tr").fadeOut(function () {
            console.log("out");

        }) ;

    };

    var error = function () {
        alert("Something failed! in getting orders");
    };

    var changedNumberOfOrders =function(ordersCount) 
    {
        console.log("detect new order called");
        if (OrderController.count != 0 && OrderController.count != ordersCount) {
            var sound = document.getElementById("audio");
            sound.muted = false;
            sound.play();
            $("#newOrder").modal();
            //document.location.reload(true);
        }
    }

    var acceptNewOrder = function(id , e) {
        console.log("accept new order" + id);
        orderService.callAcceptOrder(successAccept, error, id , e);

    }

    var init = function (ordersCount) {
        
        console.log("start order controller");
        console.log(ordersCount);
        getOrders(success, error);
        changedNumberOfOrders(ordersCount);
    };

    return {
        init: init,
        count: count,
        changedNumberOfOrders: changedNumberOfOrders,
        acceptNewOrder: acceptNewOrder

    }
}(OrderService)
