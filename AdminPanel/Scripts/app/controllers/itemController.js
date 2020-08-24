var ItemController = function (itemService) {
    var items;
    var getItems = function (success, error) {
        console.log("start calling item api");
        itemService.callItemGetApi(success, error);
        return items;
    }
    
    var successGetItems = function (items) {
        console.log("retrieved items");
        //console.log(items);
        ItemController.items = items;
        console.log(ItemController.items);
        showData();


        
       
        //return items;
    };

    var errorGetItems = function () {
        alert("Something failed! in getting items");
    };
    var successEdit = function (items) {
        console.log("edited item");
        //console.log(items);

        //return items;
    };

    var errorEdit = function () {
        alert("Something failed! in edit item");
    };
        
    var showData = function () {
        console.log("showData retrieved items");
        console.log(ItemController.items);
        $("#simple-table-Items").DataTable({
            //data: ItemController.items,
            //ajax: ItemController.items,
            //ajax: {
            //    url: "/api/Orders",
            //    //dataSrc: 'results'
            //},
            //columns: [
            //    { data: 'eldahanPresetId' },
            //    { data: 'name' },
            //    { data: 'name2' },
            //    { data: 'staticPrice' },
            //   // { data: 'staticPrice' },
            //    //{ data: 'staticPrice' }
 
            //]
       
        });
    }

    

    var init = function () {
        console.log("start item controller");
        getItems(successGetItems, errorGetItems);
        return this.items;

    };



    var editItem = function(id , e) {
        console.log("start edit item");
        itemService.callEditItem(successEdit, errorEdit , id);
    }

    var listItemUnAvailable = function (id, e, available) {
            console.log("List Item unavailable");
            itemService.callItemUnAvailable(successEdit, errorEdit , id , available);
        }


    return {
        init: init,
        editItem: editItem,
        listItemUnAvailable: listItemUnAvailable,
        items: items
    }
}(ItemService)