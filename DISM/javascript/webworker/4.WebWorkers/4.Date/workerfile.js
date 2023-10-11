
    function timedCount() {
  var d=new Date();
        postMessage(d);
        setTimeout("timedCount()",1000);
      }
      
      timedCount();
