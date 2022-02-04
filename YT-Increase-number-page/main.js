window.onload = function(e){ 
    console.log("document.onload");
    //
    time = localStorage.getItem("YT_SaveTime");
    var TimeData = document.getElementById("myInputTime");
    TimeData.setAttribute('value',time);
    //
    day = localStorage.getItem("YT_SaveDay");
    var copyDay = document.getElementById('day');
    if(day != null){
        copyDay.setAttribute('value',day);
    }else{
        copyDay.setAttribute('value','1');
    }
    //
    channelData = localStorage.getItem('YT_SaveChanel');
    var channel = document.getElementById('Channel');
    if(channelData != null){
        channel.value = channelData;
    }else{
        channel.value = 'Funny';
    }
}
var index = 0;
var day = 1;
var chanel = 0;
var arrGMT =[+07,-10,-09,-09,-08,-08,-08,-07,-07,-07,-07,-06,-06,-06,-05,-05,-05,-05,-05,-05,-05,-04,-04,-03,-03,-03,-03,-03,-03,-03,-02,00,00,00,+01,+01,+01,+01,+01,+01,+01,+01,+01,+01,+01,+01,+01,+01,+02,+02,+02,+02,+02,+03,+03,+03,+03,+03,+03,+05,+05,+06,+07,+07,+08,+08,+08,+08,+08,+08,+08,+09,+09,+09,+09,+10,+10,+10,+11,+11,+11,+11,+12,+13,+13];
//var arrGMT =[+07,-10,-09,-09,-08,-08,-08,-07,-07,-07,-07,-06,-06,-06,-05,-05,-05,-05,-05,-05,-05,-04,-04,-03,-03,-03,-03,-03,-03,-03,-02,00,00,00,+01,+01,+01,+01,+01,+01,+01,+01,+01,+01,+01,+01,+01,+01,+02,+02,+02,+02,+02,+03,+03,+03,+03,+03,+03,+05,+05,+06,+07,+07,+08,+08,+08,+08,+08,+08,+08,+09,+09,+09,+09,+10,+10,+10,+11,+11,+11,+11,+12,+13,+13];
//console.log(arrGMT);
function unique(arr) {
    var newArr = []
    for (var i = 0; i < arr.length; i++) {
        if (newArr.indexOf(arr[i]) === -1) {
        newArr.push(arr[i])
        }
    }
    return newArr
}
var arr=unique(arrGMT).sort(function(a, b) {
                            return a - b;
                            });
//console.log(arr.length);
//console.log(arr);
var MuiGios = [0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23];
function getNumberViaIndex(index){
    switch(index){
        case 0 : return 0;
        //case 1 : return 61;
        case 2 : return 59;
        //case 3 : return -1;
        case 4 : return 53;
        //case 5 : return 48;
        case 6 : return 34;
        //case 7 : return 31;
        case 8 : return -1;
        //case 9 : return 30;
        case 10: return 23;
        //case 11: return 21;
        case 12: return 15;
        //case 13: return 11;
        case 14: return 7;
        //case 15: return 4;
        case 16: return 2;
        //case 17: return 1;
        case 18: return 83;
        //case 19: return 82;
        case 20: return 78;
        //case 21: return 75;
        case 22: return 71;
        //case 23: return 64;
        default: return 0;
    }
}
function myFunctionCopyTime() {
    
    var TimeData = document.getElementById("myInputTime");
    /* Get the text field */
    var index2 = getNumberViaIndex(index);
    if(index2<0) {
        index = index+2;
        index2 = getNumberViaIndex(index);
    }
    TimeData.setAttribute('value',index2);
    document.getElementById('timeLabel').innerText =index+'h:00';
    /* Select the text field */
    TimeData.select();
    /* Copy the text inside the text field */
    navigator.clipboard.writeText(TimeData.value)
    if(index == 24) {
        index = -2;
        TimeData.setAttribute('value',0);
        //Chon lai day
        day = Number(day)+1;
        setDay(day);
        //console.log('index='+day);
        navigator.clipboard.writeText(24)
    }
    index = index+2;
    //Save data to local Storage
    SaveToStorage(TimeData.value,day);
}
function myFunctionClearTime() {
    index = 0;
    /* Get the text field */
    var TimeData = document.getElementById("myInputTime");
    /* Select the text field */
    TimeData.select();
    TimeData.setAttribute('value',index)
}
///Day
function myFunctionCopyDay(day) {           
var copyDay = document.getElementById('day');
    copyDay.select();
    navigator.clipboard.writeText(copyDay.value);
}
function myFunctionClearDay() {
var copyDay = document.getElementById('day');
    day = 1;
    /* Get the text field */
    /* Select the text field */
    //copyDay.select();
    copyDay.setAttribute('value', 1);
}
function setDay(day) {
    var copyDay = document.getElementById('day');
        copyDay.setAttribute('value', day);  
}
function myFunctionSetStartDay() {
    var copyDay = document.getElementById('dayTemp');
    
    day =Number(copyDay.value);
    console.log('start:'+day);
    setDay(day);
}
function myFunctionCheckOK() {
    var copyValueOK = document.getElementById('checkOK');
    /* Select the text field */
    copyValueOK.select();
    /* Copy the text inside the text field */
    navigator.clipboard.writeText(copyValueOK.value);
}
function SaveToStorage(time, day, chanel){
    //Save time
    localStorage.setItem("YT_SaveTime", time);
    //Save Date
    localStorage.setItem("YT_SaveDay", day);
    //Save Chanel
    var c = document.getElementById('Channel');
    localStorage.setItem("YT_SaveChanel", c.value);
}
function determineChannel(){
    var c = document.getElementById('Channel');
    navigator.clipboard.writeText(c.value);
}
function myFunctionResetAll(){
    localStorage.clear();
    location.reload();
}