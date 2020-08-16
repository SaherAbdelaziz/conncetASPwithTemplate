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

    var callOrderGetSingleApi = function (success, errorSingle, id) {
        console.log("start calling getting single order api");
        // if id =-1 gets  last inserted order else gets the order that matches the id
       

        $.ajax({
            url: `/api/Orders/${id}`,
            type: "GET",
            contentType: 'application/json; charset=utf-8',
            datatype: "json",
            success: success,
            error: errorSingle
        });

    }

    //return data 
    var callOrderAndHisChecksItems = function (success, errorSingle, id) {
        console.log("start calling order and his items");
        //should return order and items associated with it 
        $.ajax({
            url: `/api/ChecksItems/${id}`,
            type: "GET",
            contentType: 'application/json; charset=utf-8',
            datatype: "json",
            success: success,
            error: errorSingle
        });

       
    }

    var callLockRow = function(id){//(success, errorSingle, id) {
        //should lock table till close the pop up window
        console.log("call lock table for no use");
        //console.log("the iddddd",id);
        //console.log(typeof id);
        var availableTable = {
            IDRow: id
        };

        $.ajax({
            url: `/api/AvailableTables`,
            type: "POST",
            dataType: 'json',
            data: JSON.stringify(availableTable),
            contentType: "application/json; charset=utf-8",
            success: function() {
                console.log("row locked");
            },
            error: function () {
                console.log("row locked error");
            }
        });
    }

    var callCheckRow = function (success, error, id , data) {
        //check row
        console.log("call Check Row");


        $.ajax({
            url: `/api/AvailableTables/${id}`,
            type: "GET",
            dataType: 'json',
            contentType: "application/json; charset=utf-8",
            success: success,
            error: function() {
                error(data, id);
            }
        });
        }


    var callAcceptOrder = function (successAccept, error, id) {
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
            success: successAccept(id),
            error: error
        });
    }
    var callRejectOrder = function (successReject, error, id) {
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
            success: successReject(id),
            error: error
        });
    }
    //this should modify locks table and remove the admin 
    //id from it to reopen the order for any one to check the order again

    var callCloseModelOrderDetails = function (successUnlock, error, id) {
        console.log("start calling removing admin id");
        console.log("removing admin id");

        $.ajax({
            url: `/api/AvailableTables/${id}`,
            type: "DELETE",
            dataType: 'json',
            contentType: "application/json; charset=utf-8",
            success: function () {
                console.log("row Unlocked");
            },
            error: function () {
                console.log("row Unlocked error");
            }
        });
    }
    
    var callEditOrder = function (successEdited, error, id, e) {
        console.log("start calling Edit order api");

        var actionUrl = `/Orders/Edit/${id}`;
            window.open(actionUrl);

    }
    var callOrderDetails = function (id, e) {
            console.log("start Order Details");

            

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
        callCloseModelOrderDetails: callCloseModelOrderDetails,
        callLockRow: callLockRow,
        callCheckRow: callCheckRow,
        callEditOrder: callEditOrder,
        callOrderDetails: callOrderDetails,
        callEditOrderItem: callEditOrderItem,
        callOrderGetSingleApi:callOrderGetSingleApi,
        callOrderAndHisChecksItems:callOrderAndHisChecksItems

    }

}()