var ItemService = function () {


    var callItemGetApi = function (success, error) {
        console.log("start calling item inside function api");
        $.ajax({
            url: "/api/Item",
            type: "GET",
            dataType: "json",
            success: success,
            error: error
        });

    }

    var callEditItem = function (success, error , id) {
        console.log("start calling edit item");
        console.log(id);
        var actionUrl = `/Items/Edit/${id}`;
        window.open(actionUrl);

        //    $.ajax({
        //        url: `/Items/Edit/${id}`,
        //        type: "GET",
        //        dataType: "json",
        //        success: success,
        //        error: error
        //    });

        }

    var callItemUnAvailable = function (success, error, id, available) {
            console.log("call item is not available ");
            console.log(id);

            var item = {
                Id: id,
                Available: 1
            };

            $.ajax({
                url: `/api/Item`,
                type: "PUT",
                data: JSON.stringify(item),
                contentType: 'application/json; charset=utf-8',
                datatype: "Json",
                success: success,
                error: error
            });

            

            }


    return {
        callItemGetApi: callItemGetApi,
        callEditItem: callEditItem,
        callItemUnAvailable: callItemUnAvailable,

    }

}()