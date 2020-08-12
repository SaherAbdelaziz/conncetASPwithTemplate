﻿var OrderController = function (orderService) {
    var orders , count=0 , userId;
    var getOrders = function (success, error) {
        console.log("start calling order api");
        orderService.callOrderGetApi(success, error);
    }


    var getOrderedItems = function (success, error) {
        console.log("start calling order api");
        orderService.callOrderedItemsGetApi(success, error);
    }
    
    var success = function (orders) {
        //console.log("retrieved orders");
        //console.log(orders);
       
        OrderController.orders = orders;
        //console.log(OrderController.orders);
        OrderController.count = OrderController.orders.length;
    };

    //var successAccept = function (e) {
    //    console.log(" order accepted");
    //    var td = $(e.target);
    //    td.parents("tr").fadeOut(function () {
    //        console.log("out");
    //        document.location.reload(true);
    //    }) ;

    //};

    var successAccept = function (id) {
        console.log(` ${id} order accepted`);
        //document.location.reload(true);
        $('#orderDetailsModel').on('hidden.bs.modal',
            function() {
                location.reload();
            });

    };
    var successReject = function (id) {
        console.log(` ${id} order rejected`);
        //document.location.reload(true);
        $('#orderDetailsModel').on('hidden.bs.modal',
            function () {
                location.reload();
            });

    };

    //var successReject = function (e) {
    //    console.log(" order rejected");
    //    var td = $(e.target);
    //    td.parents("tr").fadeOut(function () {
    //        console.log("out");
    //        document.location.reload(true);
    //    });

    //};

    var successEdited = function (e) {
        console.log(" order edited");
        document.location.reload(true);

    };

    var successSingle = function (order) {
        console.log(" order single retrieved ");
        console.log(order);
        var sound = document.getElementById("audio");
        sound.muted = false;
            
        sound.play();
           
        var text = `you have new order from ${order.applicationUser.name} with price ${order.totalPrice}`;
        $('#newOrderModel .modal-body').text( text);
        $("#newOrderModel").modal();
        

    };
    var successSingleDetails = function (orderAndCheckItems) {
            console.log(" order single details retrieved ");
            console.log(orderAndCheckItems);
            var items = "";
           
            for (var i = 0; i < orderAndCheckItems.checksItems.length ; i++) {

                if (orderAndCheckItems.checksItems[i].isModifier === false)
                    items += `<div>${orderAndCheckItems.checksItems[i].qty}x ${orderAndCheckItems.checksItems[i].item.name}    Price   ${orderAndCheckItems.checksItems[i].unitPrice}</div>`;
                else if (orderAndCheckItems.checksItems[i].status === "Preparing")
                    items += `<div>* ${orderAndCheckItems.checksItems[i].item.name}</div>`;
                else 
                    items += `<div> spiceal instructions ${orderAndCheckItems.checksItems[i].status}</div>`;

            }
            var text =



                `<h3> Order Number ${orderAndCheckItems.order.id}</h2>
                <div class ="mx-auto" style="width: 200px;">
                <h4>Customer Details</h3>
                <div>Name ${orderAndCheckItems.order.user.name}</div>
                <div>Area ${orderAndCheckItems.order.user.area.name}</div>
                <div>Outlet ${orderAndCheckItems.order.user.outlet.name}</div>
                <div>
                Addres ${orderAndCheckItems.order.user.adress}
                ${orderAndCheckItems.order.user.adress2}
                ${orderAndCheckItems.order.user.building}
                ${orderAndCheckItems.order.user.floor}
                ${orderAndCheckItems.order.user.apartment}
                ${orderAndCheckItems.order.user.specialMark}
                </div>

                </div>
                <h4>Order Details</h3>
                <div class ="mx-auto" style="width: 800px;">
               
                ${items}


                </div>`;
            var buttons =
                `
                <button type="button" class ="btn btn-secondary" data-dismiss="modal">Close</button>
                <button type="button" class ="btn btn-danger js-btn-RejectOrder" data-dismiss="modal" data-order-id="${orderAndCheckItems.order.id}">Reject</button>
                <button type="button" class ="btn btn-success js-btn-AcceptOrder" data-dismiss="modal" data-order-id="${orderAndCheckItems.order.id}">Accept </button>
                
                `
            $('#orderDetailsModel .modal-body').html(text);
            $('#orderDetailsModel .modal-footer').html(buttons);
            $("#orderDetailsModel").modal();
            //orderService.callOrderDetails(id, e);

        };

    var error = function () {
        alert("Something failed! in getting orders");
    };

    var errorSingle = function () {
        alert("Something failed! in getting single order");
    };


    var changedNumberOfOrders =function(ordersCount) 
    {
        console.log("detect if new order called");
        if (OrderController.count != 0 && OrderController.count != ordersCount) {
            console.log("from controller " + OrderController.count + " displayed  " + ordersCount);
            orderService.callOrderGetSingleApi(successSingle, error , -1);
           
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

    //var getLastOrder = function (id, e) {
    //    console.log("Last order" + id);
    //    orderService.callAcceptOrder(successAccept, error, id, e);

    //}
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
    var orderDetails = function (id, e) {
        console.log("orderDetails" + id);
        orderService.callOrderAndHisChecksItems(successSingleDetails, error, id);

    }

    var editItemsOrder = function (id, e) {
            console.log("edit orderItem" + id);
            orderService.callEditOrderItem(successEdited, error, id, e);
    
        }

    var init = function (ordersCount) {
        console.log("userId" , userId);
        console.log("start order controller");
        console.log(ordersCount);
        getOrders(success, error);
        //getOrderedItems(success, error);
        //changedNumberOfOrders(ordersCount);
        //showData();
    };

    return {
        init: init,
        count: count,
        changedNumberOfOrders: changedNumberOfOrders,
        acceptNewOrder: acceptNewOrder,
        rejectNewOrder: rejectNewOrder,
        editOrder: editOrder,
        orderDetails: orderDetails,
        editItemsOrder:editItemsOrder,
        showData: showData,
        userId: userId

    }
}(OrderService)
