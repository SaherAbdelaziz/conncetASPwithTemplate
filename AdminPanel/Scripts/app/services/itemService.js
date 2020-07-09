var ItemService = function () {


    var callItemGetApi = function (success, error) {
        console.log("start calling item inside function api");
        $.ajax({
            url: "/api/EldahanItems",
            type: "GET",
            dataType: "json",
            success: success,
            error: error
        });

    }


    return {
        callItemGetApi: callItemGetApi

    }

}()