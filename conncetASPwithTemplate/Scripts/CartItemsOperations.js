
// with this function we call api to retrive all cartItems belongs to current loged in user

function AJAXRequest() {
    //js-shopping-cart
    // here we get cart items from api and put in in table in cart


    $.ajax({
        url: "/api/shoppingcarts",
        type: "GET",
        dataType: 'json',
        success: function (notifications) {
            var delivery = 3.99, price = 0, totalPrice = 0;
            console.log("called " + notifications.length);
            if (notifications.length === 0)
                return $(".js-notifications-price").text('$0');
            $(".js-notifications-count").text(notifications.length);

            $('.seed_items').empty();
            $('.seed_price').empty();
            for (let i = 0; i < notifications.length; i++) {
                //console.log(notifications.items);
                //names//price// delete and edit
                var data1 =
                    `<tr>
                        <td class ="title">
                            <span class ="name col-md-30"><a href="#productModal" data-toggle="modal">${notifications[i].eldahanItem.name}</a></span>
                            <span class ="caption text-muted">${notifications[i].eldahanItem.name2}</span>

                        <td class ="quantity" quantity =${notifications[i].quantity}>  ${notifications[i].quantity} 
                        <td class ="price" price =${notifications[i].eldahanItem.staticPrice}>  ${notifications[i].eldahanItem.staticPrice}LE 

                        <td  class ="actions">
                         <a href="#" class ="action-icon js-cancel-item" data-item-id=${notifications[i].id}> <i data-item-id=${notifications[i].id}  class ="ti ti-close "></i></a>
                       
                    `;

                price += notifications[i].eldahanItem.staticPrice * notifications[i].quantity;
                totalPrice = price + delivery;
                $('.seed_items').append(data1);

            }

            //<a href="#" class ="action-icon js-edit-item"> <i data-item-id=${notifications[i].id} class ="ti ti-pencil"></i></a>

            // price and total
            var data2 = ` <div class=" row"> <div class="col-7 text-right text-muted">
                Order total: </div>  <div class="col-5 ordertotal" ordertotal=${price}><strong>  ${price}LE </strong></div>  </div>
            <div class="row"> <div class="col-7 text-right text-muted">
                    Delivery: </div> <div class="col-5"><strong> ${delivery}LE </strong></div>  </div>

            <hr class="hr-sm"> <div class="row text-lg"> <div class="col-7 text-right text-muted">
                        Total: </div> <div class="col-5 total" total=${totalPrice}><strong> ${totalPrice}LE </strong></div> </div>`;

            // price beside cart
            $(".js-notifications-price").val(totalPrice.toFixed(2));
            $(".js-notifications-price").text(totalPrice.toFixed(2) + " LE");
            $('.seed_price').append(data2);
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
                var totalPrice = $('.ordertotal').attr('ordertotal');
                //console.log("itemPrice " + itemPrice);
                //console.log("totalPrice " + totalPrice);

                var price = Number(totalPrice) - Number(itemPrice);
                $('.ordertotal').attr('ordertotal', price);
                //console.log("total " + price);
                // console.log($('.ordertotal').attr('ordertotal'));
                $(this).remove();

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