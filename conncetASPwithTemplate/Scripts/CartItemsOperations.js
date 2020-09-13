
// with this function we call api to retrive all cartItems belongs to current loged in user

function AJAXRequest(discount) {
    //js-shopping-cart
    // here we get cart items from api and put in in table in cart

    $.ajax({
        url: "/api/shoppingcarts",
        type: "GET",
        dataType: 'json',
        success: function (data) {
            notifications = data.items;
            var disCount = data.disValue;
            var disName = data.disName;
            console.log("Retrived data");
            console.log(disCount);
            console.log(disName);
            console.log(data);
            console.log("called " + notifications);
            console.log("called " + notifications[0]);
            
            console.log("called " + notifications.length);
           
            if (notifications.length === 0) {
                console.log("in clear");
                $('.seed_items').empty();
                $('.seed_price').empty();
                $(".js-notifications-price").text('0 LE');
                $(".js-notifications-count").text(0);
                return;
            }
            $('.js-ordernow').prop('disabled', false);
            $('.js-order').prop('disabled', false);
            $(".js-notifications-count").text(notifications.length);
            var delivery = notifications[0].delivery, price = 0, totalPrice = 0;
            $('.seed_items').empty();
            $('.seed_price').empty();
            for (let i = 0; i < notifications.length; i++) {
                //console.log(notifications.items);
                //names//price// delete and edit
                var data1 =
                    `<tr>
                        <td class ="title">
                            <span class ="name col-md-30"><a href="#productModal" data-toggle="modal">${notifications[i].item.name}</a></span>
                            <span class ="caption text-muted">${notifications[i].item.name2}</span>

                        <td class ="quantity" quantity =${notifications[i].quantity}>  ${notifications[i].quantity} 
                        <td class ="price" price =${notifications[i].item.staticPrice}>  ${notifications[i].item.staticPrice}LE 

                        <td  class ="actions">
                         <button class ="btn btn-sm  text-danger btn-primary-outline action-icon js-cancel-item" data-item-id=${notifications[i].id}> <i data-item-id=${notifications[i].id}  class ="ti ti-close "></i></button>
                       
                    `;

                price += notifications[i].item.staticPrice * notifications[i].quantity;
                totalPrice = price + delivery - disCount;
                $('.seed_items').append(data1);

            }

            //<a href="#" class ="action-icon js-edit-item"> <i data-item-id=${notifications[i].id} class ="ti ti-pencil"></i></a>

            // price and total
            var data2 = ` <div class=" row"> <div class="col-7 text-right text-muted">
                Order total: </div>  <div class="col-5 ordertotal" ordertotal=${price}><strong>  ${price}LE </strong></div>  </div>
            <div class="row"> <div class="col-7 text-right text-muted">
                    Delivery: </div> <div class="col-5 delivery" delivery=${delivery}><strong> ${delivery}LE </strong></div>  </div>

            <hr class="hr-sm"> <div class="row text-lg"> <div class="col-7 text-right text-muted">
                        Total: </div> <div class="col-5 total" total=${totalPrice}><strong> ${totalPrice}LE </strong></div> </div>`;

            var data3 = `<div>${disName} promo code is applied</div>`;

            // price beside cart
            $(".js-notifications-price").val(totalPrice.toFixed(2));
            $(".js-notifications-price").text(totalPrice.toFixed(2) + " LE");
            $('.seed_price').append(data2);
            $('.js-Coupon-show').append(data3);
        },
        error: function (xhr, status, error) {
            //
        }
    });
}


$(document).on("click", ".js-cancel-item", function (e) {
    console.log("got on delete");
    //if ($('.js-cancel-item').length > 0) {
    console.log(e.target);
    //$(".js-cancel-item").click(function(e) {

    var link = $(e.target);
    $.ajax({
            url: "/api/shoppingcarts/" + link.attr("data-item-id"),
            method: "DELETE"
        })
        .done(function () {
            link.parents("tr").fadeOut(function () {
                var itemPrice = link.parents("tr").find('.price').attr('price');
                var itemQuantity = link.parents("tr").find('.quantity').attr('quantity');
                var totalPrice = $('.ordertotal').attr('ordertotal');
                console.log("itemPrice " + itemPrice);
                //console.log("totalPrice " + totalPrice);

                var price = Number(totalPrice) - (Number(itemPrice) * Number(itemQuantity));
                console.log("Q + Price " + price);

                $('.ordertotal').attr('ordertotal', price);
                //console.log("total " + price);
                // console.log($('.ordertotal').attr('ordertotal'));
                //$(this).remove();

                //console.log($('.ordertotal').text(5));
                //console.log($(this));
                var total = price + 3.99;
                $('.ordertotal strong').text(price + "LE");
                $('.total strong').text(total + "LE");

                AJAXRequest();
            });
        })
        .fail(function () {
            alert("Something failed! in deleting items");
        });
});