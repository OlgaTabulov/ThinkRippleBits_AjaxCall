function DoClick() {
    var params = {};
    var uri = 'api/random/GetSample/';
    CallAjax(uri, params, DoClick_OnSuccess);
}

function DoClick_OnSuccess(data, status) {
    if (status === 'success') {
        $("#result").html(data);
    }
    else {
        alert("error: " + data);
    }
}