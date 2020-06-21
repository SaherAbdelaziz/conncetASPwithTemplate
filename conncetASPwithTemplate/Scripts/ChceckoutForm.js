$(".js-ordernow").on('click',
            function (e) {
                
                
                $(".js-ordernow span").text("Confirmed");
                $('.js-ordernow').prop('disabled', true);
                console.log("create order");
                console.log("selected is " + $('#deliverytime option:selected').index());
                var deliverytimeIndex = $('#deliverytime option:selected').index();
                
                //console.log($('.ordertotal').attr('ordertotal'));
                var order = {
                    Price: Number($('.ordertotal').attr('ordertotal')),
                    DeliveryTime:deliverytimeIndex
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

                    })
                    .fail(function () {
                        alert("Something failed! in adding order");
                    });
            });