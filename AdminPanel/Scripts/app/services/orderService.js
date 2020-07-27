var OrderService = function() {


    var callOrderGetApi = function (successSingle, error) {
        console.log("start calling getting order api");
        $.ajax({
            url: "/api/Orders",
            type: "GET",
            dataType: "json",
            success: successSingle,
            error: error
        });

    }

    var callOrderedItemsGetApi = function (success, error) {
        console.log("start calling getting OrderedItems api");
        $.ajax({
            url: "/api/OrderedItems",
            type: "GET",
            dataType: "json",
            success: success,
            error: error
        });

    }

    var callOrderGetSingleApi = function (successSingle, errorSingle) {
        console.log("start calling getting single order api");
        var id = -1;

        $.ajax({
            url: `/api/Orders/${id}`,
            type: "GET",
            contentType: 'application/json; charset=utf-8',
            datatype: "json",
            success: successSingle,
            error: errorSingle
        });

    }

    var callAcceptOrder = function (successAccept, error, id , e) {
        console.log("start calling Accepting order api");
        var order = {
            Id: id,
            OrderState:1
              };
        //console.log(id);
        $.ajax({
            url: `/api/Orders`,
            type: "PUT",
            data: JSON.stringify(order),
            contentType: 'application/json; charset=utf-8',
            datatype: "Json",
            success: successAccept(e),
            error: error
        });
    }
    var callRejectOrder = function (successReject, error, id, e) {
        console.log("start calling Reject order api");
        var order = {
            Id: id,
            OrderState:2
              };
        //console.log(id);
        $.ajax({
            url: `/api/Orders`,
            type: "PUT",
            data: JSON.stringify(order),
            contentType: 'application/json; charset=utf-8',
            datatype: "Json",
            success: successReject(e),
            error: error
        });
    }
    
    var callEditOrder = function (successEdited, error, id, e) {
        console.log("start calling Edit order api");

        var actionUrl = `/Orders/Edit/${id}`;
            window.open(actionUrl);

    }

    var callEditOrderItem = function (successEdited, error, id, e) {
        console.log("start calling Edit order api");

        var actionUrl = `/Orders/EditItems/${id}`;
            window.open(actionUrl);

    }
    return {
        callOrderGetApi: callOrderGetApi,
        callOrderedItemsGetApi:callOrderedItemsGetApi,
        callAcceptOrder: callAcceptOrder,
        callRejectOrder: callRejectOrder,
        callEditOrder: callEditOrder,
        callEditOrderItem: callEditOrderItem,
        callOrderGetSingleApi:callOrderGetSingleApi

    }

}()