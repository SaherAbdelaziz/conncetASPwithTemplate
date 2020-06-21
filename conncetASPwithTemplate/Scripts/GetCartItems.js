﻿
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
                            <span class ="name col-md-30"><a href="#productModal" data-toggle="modal">${notifications[i].item.name}</a></span>
                            <span class ="caption text-muted">${notifications[i].item.name2}</span>

                        <td class ="quantity" quantity =${notifications[i].quantity}>  ${notifications[i].quantity} 
                        <td class ="price" price =${notifications[i].item.staticPrice}>  ${notifications[i].item.staticPrice}LE 

                        <td  class ="actions">
                         <a href="#" class ="action-icon js-cancel-item" data-item-id=${notifications[i].id}> <i data-item-id=${notifications[i].id}  class ="ti ti-close "></i></a>
                       
                    `;

                price += notifications[i].item.staticPrice * notifications[i].quantity;
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
    