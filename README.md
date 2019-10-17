# Calling Ajax Made Clean
Make Ajax calls into one-liner throughout your solution to make it clean and readable


CallAjax(uri, params, DoClick_OnSuccess);

    function CallAjax(url, params, success, error, type) {
                    url = (typeof url === 'string') ? url : "";
                    params = params || {};
                    success = success || defaultSuccessFunction;
                    error = error || defaultErrorFunction;
                    type = type || 'GET';

                    var respObj = $.ajax({
                        type: type,
                        url: url,
                        data: params,
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        success: success,
                        error: error
                    });
                    return respObj;
                }

                var defaultSuccessFunction = function (xml, status, xhr) { };
                var defaultErrorFunction = function (XMLHttpRequest, textStatus, errorThrown) {
                    console.log("Status: " + textStatus);
                    console.log("Error: " + errorThrown);
                };
            

code reference at
thinkRippleBits_AjaxCall/wwwroot/js/index.js
thinkRippleBits_AjaxCall/wwwroot/js/site.js
