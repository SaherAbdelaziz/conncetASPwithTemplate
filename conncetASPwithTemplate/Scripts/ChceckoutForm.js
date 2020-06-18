$(".js-ordernow").on('click',
            function (e) {

                console.log("create order");

                console.log($(".ordertotal").val());
                console.log($('.ordertotal').attr('ordertotal'));
                var order = {
                    Price: Number($('.ordertotal').attr('ordertotal')),
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