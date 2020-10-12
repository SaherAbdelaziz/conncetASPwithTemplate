var PresetController = function (presetService) {
    var presets;
    var getPresets = function (success, error) {
        console.log("start calling presets api");
        presetService.callPresetsGetApi(success, error);
        return presets;
    }

    var successGetPresets = function (presets) {
        console.log("retrieved presets");

        PresetController.presets = presets;
        console.log(PresetController.presets);
        showData();

    };

    var errorGetPresets = function () {
        alert("Something failed! in getting presets");
    };
    var successEdit = function (presets) {
        console.log("edited presets");
    };

    var errorEdit = function () {
        alert("Something failed! in edit preset");
    };

    var showData = function () {
        console.log("showData retrieved presets");
        console.log(PresetController.presets);
        $("#simple-table-Presets").DataTable({

        });
    }



    var init = function () {
        console.log("start preset controller");
        getPresets(successGetPresets, errorGetPresets);
        return this.presets;

    };



    var editPreset = function (id, e) {
        console.log("start edit item");
        presetService.callEditPreset(successEdit, errorEdit, id);
    }



    return {
        init: init,
        editPreset: editPreset,
        presets: presets
    }
}(PresetService)