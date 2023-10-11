// import {name} from './userdata.js';
import * as userdata from './userdata.js';

var btnsave = document.getElementById("btnsave")
// var ab  = localStorage.getItem("userdata");
// console.log(userdata.userdataArray)

btnsave.addEventListener('click', function () {


    var fname = document.getElementById("fname").value;
    var Cname = document.getElementById("Cname").value;
    var objUserData = new userdata.Cl_userdata();


    debugger

    objUserData.Name = fname; //zohair
    objUserData.Class = Cname;
    var ID = 123
    var obj = {
        ID: ID,
        name: objUserData.Name,
        class: objUserData.Class
    }
    userdata.userdataArray.push(obj)
    console.log(userdata.userdataArray)
    localStorage.setItem("userdata", JSON.stringify(userdata.userdataArray))
})



// alert(name);















// 
// alert(lib.name);