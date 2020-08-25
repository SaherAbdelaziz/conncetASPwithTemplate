var ModifiersGroupsController = function (modifiersGroupsService) {


    var init = function () {
        console.log("start modifier groups controller");

    };

    var showItemModel = function (data, id) {
        console.log("start show item model");

        $(".modal-product-details .js-item-name1").text(data.items[0].name);
        $(".modal-product-details .js-item-name2").text(data.items[0].name2);
        $(".modal-product-details .js-item-staticPrice").text(data.items[0].staticPrice);
        $(".modal-product-details .js-item-quantity").val(1);
        $(".modal-product-details .js-item-message").val('');
        $('#panelDetailsSize .panel-details-content').empty();
        $('#js-panel-details-modi').empty();

        //first item is the chosen item

        if (data.items.length == 1) {
            cartItemDto = {
                ItemId: id,
                ItemsId: [-1, -1, -1, -1] // there is no modifiers for this item

            }
            console.log("no modifiers");
            $("#productModal .js-add-cart").attr("data-selected-modiefier-id", [-1, -1, -1, -1]);
            $("#productModal .js-add-cart").attr("data-is-modiefier", 0);

        }

        else {
            $("#productModal .js-add-cart").attr("data-is-modiefier", data.modifiersGroupCount);
            console.log("in has modi");
            console.log(data.items.length);
            for (var i = 0; i < data.modifiersGroupCount; i++) {
                let dataSize = ` <h5 class="panel-details-title">
                                    <label class="custom-control custom-radio">
                                    <input name="radio_title_size${i}" type="radio" class="custom-control-input">
                                    <span class="custom-control-indicator"></span>
                                    </label>
                                    <a href="#panelDetailsSize${i}" data-toggle="collapse">Salad${i + 1}</a>
                                    </h5>
                                    <div id="panelDetailsSize${i}" class="collapse">
                                    <form>
                                    <div class="panel-details-content">

                                    </div>
                                    </form>
                                    </div>`;
                $('#js-panel-details-modi').append(dataSize);

                for (let j = 1; j < data.items.length; j++)//data.length
                {

                    // add modifiers to details of item
                    // <span class ="custom-control-indicator"></span>
                    let data1 = `<div class="form-group">
                                    <label class ="custom-control custom-radio" >
                                    <input name="radio_size${i}" type="radio" value=${data.items[j].name}>

                                    <span class ="custom-control-description">${data.items[j].name} </span>
                                    </label>
                                    </div>`;

                    $(`#panelDetailsSize${i} .panel-details-content`).append(data1);
                }
            }

            var index0 = 0, index1 = 0, index2 = 0, index3 = 0;
            $("#productModal .js-add-cart").attr("data-selected-modiefier-id", [index0 !== 0 ? data.items[index0].id : -1, index1 !== 0 ? data.items[index1].id : -1, index2 !== 0 ? data.items[index2].id : -1, index3 !== 0 ? data.items[index3].id : -1]);

            $("input[name='radio_size0']").click(function () {

                index0 = $("input[name='radio_size0']").index($("input[name='radio_size0']:checked")) + 1;
                console.log(data.items[index0].id);

                $("#productModal .js-add-cart").attr("data-selected-modiefier-id", [index0 !== 0 ? data.items[index0].id : -1, index1 !== 0 ? data.items[index1].id : -1, index2 !== 0 ? data.items[index2].id : -1, index3 !== 0 ? data.items[index3].id : -1]);
            });

            $("input[name='radio_size1']").click(function () {

                index1 = $("input[name='radio_size1']").index($("input[name='radio_size1']:checked")) + 1;
                console.log(data.items[index1].id);

                $("#productModal .js-add-cart").attr("data-selected-modiefier-id", [index0 !== 0 ? data.items[index0].id : -1, index1 !== 0 ? data.items[index1].id : -1, index2 !== 0 ? data.items[index2].id : -1, index3 !== 0 ? data.items[index3].id : -1]);
            });
            $("input[name='radio_size2']").click(function () {

                index2 = $("input[name='radio_size2']").index($("input[name='radio_size2']:checked")) + 1;
                console.log(data.items[index2].id);

                $("#productModal .js-add-cart").attr("data-selected-modiefier-id", [index0 !== 0 ? data.items[index0].id : -1, index1 !== 0 ? data.items[index1].id : -1, index2 !== 0 ? data.items[index2].id : -1, index3 !== 0 ? data.items[index3].id : -1]);
            });

            $("input[name='radio_size3']").click(function () {

                index3 = $("input[name='radio_size3']").index($("input[name='radio_size3']:checked")) + 1;
                console.log(data.items[index3].id);

                $("#productModal .js-add-cart").attr("data-selected-modiefier-id", [index0 !== 0 ? data.items[index0].id : -1, index1 !== 0 ? data.items[index1].id : -1, index2 !== 0 ? data.items[index2].id : -1, index3 !== 0 ? data.items[index3].id : -1]);
            });
        }
    }

    var successShow = function () {
        console.log("ok show");

    };


    var errorShow = function () {
        console.log("error show");

    };

    var showItem = function (id, checkId , e) {
        console.log("start show item");
        modifiersGroupsService.callShowItem(showItemModel, errorShow, id, checkId);
    }

    var addItem = function (id, checkId , e) {
        console.log("start Add item");

        var idModifiers = $("#productModal .js-add-cart").attr("data-selected-modiefier-id");
        var isModi = $("#productModal .js-add-cart").attr("data-is-modiefier");


        idModifiers = JSON.parse("[" + idModifiers + "]");
        //console.log("idModList.Count" , idModList.length);

        if (isModi !== 0) {
            console.log("in condetion ");
            for (let i = 0; i < isModi; i++) {
                //console.log(idModifiers);
                if (idModifiers[i] === -1) {
                    alert("Please choose all salads");
                    return;
                }
            }

        }

        var id = $("#productModal .js-add-cart").attr("data-item-id");
        var checkId = $("#productModal .js-add-cart").attr("data-check-id");
        var detailsMessage = $("#productModal .js-item-message").val();
        var quantity = $("#productModal .js-item-quantity").val();


        var cartItemDto = {
            ItemId: id,
            ItemsId: idModifiers,
            Details: detailsMessage,
            Quantity: quantity,
            CheckId: checkId
        }

        console.log(cartItemDto);
        modifiersGroupsService.callAddItem(cartItemDto);
    }

    
return {
    init: init,
    showItem: showItem,
    addItem: addItem
   
}
}(ModifiersGroupsService)
