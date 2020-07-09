var ItemController = function (itemService) {
    var items;
    var getItems = function (success, error) {
        console.log("start calling item api");
        itemService.callItemGetApi(success, error);
        return items;
    }
    
    var success = function (items) {
        console.log("retrieved items");
        //console.log(items);
        ItemController.items = items;
        console.log(ItemController.items);
        showData();


        
       
        //return items;
    };

    var error = function () {
        alert("Something failed! in getting items");
    };
        
    var showData = function () {
        console.log("showData retrieved items");
        console.log(ItemController.items);
        $("#simple-table-Items").DataTable({
            data: ItemController.items,
            //ajax: ItemController.items,
            //ajax: {
            //    url: "/api/Orders",
            //    //dataSrc: 'results'
            //},
            columns: [
                { data: 'eldahanPresetId' },
                { data: 'name' },
                { data: 'name2' },
                { data: 'staticPrice' },
               // { data: 'staticPrice' },
                //{ data: 'staticPrice' }
 
            ]
       
        });
    }

    

    var init = function () {
        console.log("start item controller");
        getItems(success, error);
        return this.items;

    };

    return {
        init: init,
        success: success,
        items: items
    }
}(ItemService)