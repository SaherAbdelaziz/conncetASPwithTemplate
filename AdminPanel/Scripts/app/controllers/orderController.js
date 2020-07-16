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
    var successReject = function (e) {
        console.log(" order rejected");
        var td = $(e.target);
        td.parents("tr").fadeOut(function () {
            console.log("out");

        }) ;

    };

    var successEdited = function (e) {
        console.log(" order edited");


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
            $("#newOrderModel").modal();
            //document.location.reload(true);
        }
    }

    var showData = function () {
        console.log("showData retrieved orders");
        //console.log(ItemController.items);
        $("#NewOrder").DataTable({
            //data: ItemController.items,
            //ajax: ItemController.items,
            //ajax: {
            //    url: "/api/Orders",
            //    //dataSrc: 'results'
            //},
            //columns: [
            //    { data: 'eldahanPresetId' },
            //    { data: 'name' },
            //    { data: 'name2' },
            //    { data: 'staticPrice' },
            //   // { data: 'staticPrice' },
            //    //{ data: 'staticPrice' }

            //]

        });

        $("#AcceptedOrders").DataTable({
        });

        $("#RejectedOrders").DataTable({
        });

        $("#AllOrders").DataTable({
        });
    }


    var acceptNewOrder = function(id , e) {
        console.log("accept new order" + id);
        orderService.callAcceptOrder(successAccept, error, id , e);

    }
    var rejectNewOrder = function (id, e) {
            console.log("reject new order" + id);
            orderService.callRejectOrder(successReject, error, id, e);
    
    }
    var editOrder = function (id, e) {
            console.log("edit order" + id);
            orderService.callEditOrder(successEdited, error, id, e);
    
        }

    var init = function (ordersCount) {
        
        console.log("start order controller");
        console.log(ordersCount);
        getOrders(success, error);
        //changedNumberOfOrders(ordersCount);
        //showData();
    };

    return {
        init: init,
        count: count,
        changedNumberOfOrders: changedNumberOfOrders,
        acceptNewOrder: acceptNewOrder,
        rejectNewOrder: rejectNewOrder,
        editOrder:editOrder,
        showData: showData

    }
}(OrderService)
