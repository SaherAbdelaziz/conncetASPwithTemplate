var OrderController = function (orderService) {
    var orders , count=0;
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
        $("#orderDetailsModel").on('hidden.bs.modal',
            function() {
                location.reload();
            });

    };


    //var successAcceptMail = function (id) {
    //    console.log(` mail sent`);

    //};
    var successReject = function (id) {
        console.log(` ${id} order rejected`);
        //document.location.reload(true);
       
        $('#orderDetailsModel').on('hidden.bs.modal',
            function () {
                location.reload();
            });


    };
     var successUnlock = function (id) {
            console.log(` ${id} should unlocked`);
            //document.location.reload(true);
           

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
    var successMailSent = function () {
            alert(" Mail Sent");
            //document.location.reload(true);

        };

    var successSingle = function (order) {
        console.log(" order single retrieved ");
        console.log(order);
        var sound = document.getElementById("audio");
        sound.muted = false;
            
        sound.play();
           
        var text = `you have new order from ${order.user.name} with price ${order.totalPrice}`;
        $('#newOrderModel .modal-body').text( text);
        $("#newOrderModel").modal();
        

    };

    var successIsOpened = function (row) {

        alert(` order is opened right now from Admin  ${row.computerName}`);
        console.log(row);

    };
    var errorNotOpened = function (data ,id) {
        console.log(" not opened");
        //call lock
        console.log("call lock table for no use", id);
        console.log("data ");
        console.log(data );
        orderService.callLockRow(id);
        successSingleDetailsImplement(data);

    };

    var successSingleMail = function (orderAndCheckItems , state , message) {
       //here we have order details and user details and we should use user mail to send  accept message
        alert("here we sent mail");
        console.log("orderAndCheckItems ", orderAndCheckItems);
        console.log("email ", orderAndCheckItems.order.user.email);
        
        //here we sent mail
        //check if accept or reject based on state
        if(state)
            orderService.callSendMail(successMailSent, error, orderAndCheckItems, state, message);
        else
            orderService.callSendMail(successMailSent, error, orderAndCheckItems, state, message);


    };
     var successSingleDetails = function (orderAndCheckItems) { // for edit to open new window not the pop up for details


         if (false) {
             //orderService.callget(s, e, data);
         }
         else
         {
                //call lock table for no use
                //but first we have to check that no one else is opening that row at this time

                //check is not opened 
                console.log("if check is not opened ", orderAndCheckItems.order.id);
                if (orderAndCheckItems.order.orderState === 0)
                    orderService.callCheckRow(successIsOpened, errorNotOpened, orderAndCheckItems.order.id, orderAndCheckItems);
                else
                    successSingleDetailsImplement(orderAndCheckItems);
            }
           


        };

    var successSingleDetailsImplement = function (orderAndCheckItems) {

        $('#orderDetailsModel .modal-body-up').html("");

        $('#orderDetailsModel .modal-footer').html(""); 
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

        window.localStorage["reject"] = $(".rejectionmessage").val();
        console.log(window.localStorage["reject"]);
        var buttons =
            `
                <button type="button" class ="btn btn-secondary js-btn-CloseModelOrderDetails" data-dismiss="modal" data-order-id="${
                orderAndCheckItems.order.id}">Close</button>
                <button type="button" class ="btn btn-info js-btn-EditOrderItems" data-dismiss="modal" data-order-id="${
                orderAndCheckItems.order.id}">Edit</button>
                <button type="button" class ="btn btn-danger js-btn-RejectOrder" data-dismiss="modal" data-order-id="${
                orderAndCheckItems.order.id}">Reject</button>
                <button type="button" class ="btn btn-success js-btn-AcceptOrder" data-dismiss="modal" data-order-id="${
                orderAndCheckItems.order.id}">Accept </button>

                `;
        $('#orderDetailsModel .modal-body-up').html(text);
        if (orderAndCheckItems.order.orderState === 0)
             $('#orderDetailsModel .modal-footer').html(buttons);
        $("#orderDetailsModel").modal();
        //orderService.callOrderDetails(id, e);
    }

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
        orderService.callAcceptOrder(successAccept, error, id, e);
        // retrieve data for that order and user

        var message = "some message for acceptance ";
        orderService.callDataForMail(successSingleMail , error, 1 , message, id);

    }
    var rejectNewOrder = function (id, e) {
        console.log("reject new order" + id);
        orderService.callRejectOrder(successReject, error, id, e);
        // retrieve data for that order and user
        var message = $(".rejectionmessage").val();
        if (message == null || message==="")
            message = "some message for reject";
            //"some message for reject";
        orderService.callDataForMail(successSingleMail , error , 0 , message , id);
    
    }
    var closeModelOrderDetails = function (id, e) {
        console.log("close order details" + id);
        //this should modify locks table and remove the admin id 
        //from it to reopen the order for any one to check
        orderService.callCloseModelOrderDetails(successUnlock, error, id);
    
    }

    var orderDetails = function (id, e) {
        console.log("orderDetails" + id);
        orderService.callOrderAndHisChecksItems(successSingleDetails, error, id);

    }


    var editOrder = function (id, e) {
            console.log("edit order" + id);
            orderService.callEditOrder(successEdited, error, id, e);
    
    }
   
    //var editItemsOrder = function (id, e) {
    //        console.log("edit orderItem" + id);
    //        orderService.callEditOrderItem(successEdited, error, id, e);
    
    //    }
    var editOrderItems = function (id, e) {
        console.log("edit Order Items" + id);
        orderService.callEditOrderItem(successEdited, error, id, e);
        
            }

    var init = function (ordersCount) {
        var x = window.localStorage.getItem('user');
        console.log("start order controller");
        console.log(x);
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
        closeModelOrderDetails: closeModelOrderDetails,
        editOrder: editOrder,
        orderDetails: orderDetails,
        //editItemsOrder:editItemsOrder,
        editOrderItems: editOrderItems,
        showData: showData

    }
}(OrderService)
