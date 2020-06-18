$(".js-ordernow").on('click',
            function (e) {

                console.log("create order");

                console.log($(".js-notifications-price").val());
                var order = {
                    Price: Number($(".js-notifications-price").val()),
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