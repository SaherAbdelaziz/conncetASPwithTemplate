var OrderService = function() {


    var callOrderGetApi = function (success, error) {
        console.log("start calling order api");
        $.ajax({
            url: "/api/Orders",
            type: "GET",
            dataType: "json",
            success: success,
            error: error
        });

    }


    return {
        callOrderGetApi: callOrderGetApi

    }

}()