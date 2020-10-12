var PresetService = function () {


    var callPresetsGetApi = function (success, error) {
        console.log("start calling presets inside function api");
        $.ajax({
            url: "/api/Web_Preset",
            type: "GET",
            dataType: "json",
            success: success,
            error: error
        });

    }

    var callEditPreset = function (success, error, id) {
        console.log("start calling edit preset");
        console.log(id);
        var actionUrl = `/Web_Preset/Edit/${id}`;
        window.open(actionUrl);
    }

    return {
        callPresetsGetApi: callPresetsGetApi,
        callEditPreset: callEditPreset,

    }

}()