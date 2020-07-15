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
            dataType: "Json",
            success: successAccept(e),
            error: error
        });
    }


    return {
        callOrderGetApi: callOrderGetApi,
        callAcceptOrder: callAcceptOrder

    }

}()