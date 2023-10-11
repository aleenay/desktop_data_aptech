const worker=new Worker('worker.js');

function bgc(){
if(document.getElementsByTagName("body")[0].style.backgroundColor=="red"){
    document.getElementsByTagName("body")[0].style.backgroundColor="green";
}
else{
    document.getElementsByTagName("body")[0].style.backgroundColor="red";
}
}

function xx(){
  //document.getElementById("print").innerHTML="sssss";
    worker.postMessage('aatika');
}

worker.onmessage = function(message){
    document.getElementById("print").innerHTML=message.data;
}