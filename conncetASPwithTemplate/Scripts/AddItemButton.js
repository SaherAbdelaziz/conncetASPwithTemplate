// when click on item we get its information like id and name
        $(".js-chosen-item").on('click',
            function (e) {

                //refreshIntervalId = setInterval(AJAXRequest, 1500)


               // var userAuthorized = userAuthorize;

                if (!userAuthorized) {
                    console.log(userAuthorized);
                    console.log("false " + userAuthorized);

                    var url = '@Url.Action("Login", "Account" )';
                    window.location.href = url;
                    return;
                }

                //alert("dsds");
                var button = $(e.target);
                if ($(e.target).get(0).tagName == "SPAN") { button = $(e.target).parent(); }
                else { button = $(e.target); }
                console.log(button);
                
                var myId = button.attr("data-item-id");
                $("#productModal .js-add-cart").attr("data-item-id", myId);
               // console.log(button.attr("data-item-id"));
               // console.log(myId);

                //first retruferd id is the selected item and other ids is modifiers
                //$.ajax({ url: "/api/ModifiersGroups/" + myId, method: "GET" })
                //    .done(function(data) {
                        var index , cartItemDto;
                //        console.log("Got in modifiers");

                        //$(".modal-product-details .js-item-name1").text(data[0].name);
                        //$(".modal-product-details .js-item-name2").text(data[0].name2);
                        //$(".modal-product-details .js-item-staticPrice").text(data[0].staticPrice);
                        //$('#panelDetailsSize .panel-details-content').empty();

                        //first item is the chosen item

                         //if (data.length == 1) {
                             cartItemDto = {
                                 ItemId: myId,
                                 ItemsId[0]: -1 // there is no modiferis for this item

                             }
                            $.ajax({
                                    url: "/api/shoppingcarts",
                                    method: "POST",
                                    data: JSON.stringify(cartItemDto),
                                    contentType: 'application/json; charset=utf-8',
                                    dataType: "Json"
                                })
                                .done(function() {
                                    console.log("got in adding itms ");
                                    console.log(button.attr("data-item-id"));
                                    AJAXRequest();
                                })
                                .fail(function() {
                                    alert("Something failed! in adding item to cart");
                                });


                        //}

                        //else{
                        //       console.log("in");
                        //     $('#productModal').modal('show');
                        //    //let dataSize = ` <h5 class="panel-details-title">
                        //    //    <label class="custom-control custom-radio">
                        //    //    <input name="radio_title_size" type="radio" class="custom-control-input">
                        //    //    <span class="custom-control-indicator"></span>
                        //    //    </label>
                        //    //    <a href="#panelDetailsSize" data-toggle="collapse">Size</a>
                        //    //    </h5>
                        //    //    <div id="panelDetailsSize" class="collapse show">
                        //    //    <form>
                        //    //    <div class="panel-details-content">

                        //    //    </div>
                        //    //    </form>
                        //    //    </div>`;
                        //    //$('#panel-details').append(dataSize);

                        //        for (let j = 1; j < data.length; j++)
                        //        {

                        //            // add modifiers to details of item
                        //            let data1 = `<div class="form-group">
                        //        <label class ="custom-control custom-radio" >
                        //        <input name="radio_size" type="radio" value=${data[j].name}>
                        //        <span class ="custom-control-indicator"></span>
                        //        <span class ="custom-control-description">${data[j].name}} -(${data[j].staticPrice}) </span>
                        //        </label>
                        //        </div>`;

                        //            $('#panelDetailsSize .panel-details-content').append(data1);
                        //        }

                        //        //get the selected radio button

                        //        $("input[name='radio_size']").click(function()
                        //        {

                        //            index = $("input[name='radio_size']").index($("input[name='radio_size']:checked")) + 1;

                        //            $("#productModal .js-add-cart").attr("data-selected-modiefier-id", data[index].id);
                        //        });

            //             }
            //        })
            //        .fail(function() {
            //            alert("Something failed! in modifiers");
            //        });
            });

