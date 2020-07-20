$(".js-ordernow").on('click',
            function (e) {
                
                console.log($('.ordertotal').attr('ordertotal'));
                if ($('.ordertotal').attr('ordertotal') == null) {
                    alert("Please Choice Items ");
                    return;
                }

                $(".js-ordernow span").text("Confirmed");
                $('.js-ordernow').prop('disabled', true);
                console.log("create order");
                console.log("selected is " + $('#deliverytime option:selected').index());
                var deliverytimeIndex = $('#deliverytime option:selected').index();
                console.log("var is " + deliverytimeIndex);
                //console.log($('.ordertotal').attr('ordertotal'));
                var order = {
                    Price: Number($('.ordertotal').attr('ordertotal')),
                    Delivery: Number($('.delivery').attr('delivery')),
                    DeliveryTimeIndex: deliverytimeIndex
                };

                $.ajax({
                    url: "/api/Orders",
                    method: "POST",
                    data: JSON.stringify(order),
                    contentType: 'application/json; charset=utf-8',
                    dataType: "Json"
                })
                    .done(function () {
                        console.log("added new order ");
                        AJAXRequest();
                        document.location.reload(true);
                        //$.ajax({
                        //        url: "/api/ShoppingCarts",
                        //        method: "put",
                        //        contentType: 'application/json; charset=utf-8',
                        //        dataType: "Json"
                        //    })
                        //    .done(function () {
                        //        console.log(" all cartItems Updated");
                        //        //AJAXRequest();
                        //        //document.location.reload(true);

                        //    })
                        //    .fail(function () {
                        //        alert("Something failed! in Updating cartItems");
                        //    });

                    })
                    .fail(function () {
                        alert("Something failed! in adding order");
                    });



                //bootbox.dialog("Thank You! Your Order Will Be Ready Within 45 Minutes ", [{
                //    "label": "Success!",
                //    "class": "btn-success",
                //    "callback": function () {
                       
                //    }
                //}]);
               
            });