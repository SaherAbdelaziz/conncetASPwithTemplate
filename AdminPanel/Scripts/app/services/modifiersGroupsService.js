var ModifiersGroupsService = function () {


    

    var callShowItem = function (success, error , id , checkId) {

        console.log("id", id);
        console.log("ch" , checkId);
        $("#productModal .js-add-cart").attr("data-item-id", id);
        $("#productModal .js-add-cart").attr("data-check-id", checkId);

        //first retruferd id is the selected item and other ids is modifiers
        $.ajax(
                {
                    url: "/api/ModifiersGroups/" + id,
                    method: "GET"
                })
            .done(function (data) {
                var cartItemDto;
                console.log("Got in modifiers");
                console.log(data);
                success(data , id);
                
            })
            .fail(function () {
                alert("Something failed! in modifiers");
            });


    }

    var callAddItem = function (cartItemDto) {

        $.ajax({
            url: "/api/ChecksItems",
            method: "POST",
            data: JSON.stringify(cartItemDto),
            contentType: 'application/json; charset=utf-8',
            dataType: "Json"
        })
            .done(function () {
                console.log("got in adding items has modifiers ");
                location.reload();
            })
            .fail(function () {
                alert("Something failed! in adding item to cart");
            });

        //$("#productModal").removeClass('show');


        }


    return {
        callShowItem: callShowItem,
        callAddItem: callAddItem,

    }


}()