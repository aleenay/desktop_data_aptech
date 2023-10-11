
onmessage = function (message) {
    if (message.data == 'sart') {


        var j = 0;
        for (var i = 0; i <= 1009898900; i += 1) {
            j += i;
        }
    }
    postMessage(j);
}