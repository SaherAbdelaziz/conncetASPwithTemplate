var OrderService = function() {


    var callOrderGetApi = function (success, error) {
        console.log("start calling getting order api");
        $.ajax({
            url: "/api/Orders",
            type: "GET",
            dataType: "json",
            success: success,
            error: error
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
    

    return {
        callOrderGetApi: callOrderGetApi,
        callAcceptOrder: callAcceptOrder,
        callRejectOrder: callRejectOrder,
        callEditOrder: callEditOrder

    }

}()