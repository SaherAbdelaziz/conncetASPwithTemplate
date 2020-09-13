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
                var deliveryTypeIndex = $("input[name='DeliveryType']:checked").val();

                var deliveryTimeIndex = $(":radio[name='DeliveryTime']")
                    .index($(":radio[name='DeliveryTime']:checked"));

                if (deliveryTimeIndex === 1) {
                    var deliverytimeIndex2 = $(".deliverytime option:selected").index()+1;
                    deliveryTimeIndex = deliverytimeIndex2.toString();
                }
                

                console.log("var is " + deliveryTimeIndex);
                console.log("var is " + deliveryTypeIndex);


                //console.log($('.ordertotal').attr('ordertotal'));
                var order = {
                    Price: Number($('.ordertotal').attr('ordertotal')),
                    Delivery: Number($('.delivery').attr('delivery')),
                    DeliveryTimeIndex: deliveryTimeIndex,
                    DeliveryTypeIndex: deliveryTypeIndex
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
                        AJAXRequest(0);
                        //var actionUrl = `/Home/Index/`;
                        //var actionUrl = '@Url.Action("Index", "Home")';

                        var actionUrl = `/Home/Index/`;
                        window.open(actionUrl, "_self");
                        //document.location.reload(true);
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